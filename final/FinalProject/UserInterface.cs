using System.Runtime.InteropServices;
using System.Xml.Serialization;

class UserInterface{
    private Inventory _inventory = new CurrentInventory();

    public string Menu(){
        Console.WriteLine($"Welcome to the Inventory app!");
        Console.WriteLine("\nMenu options: ");
        Console.WriteLine(" 0. Quit");
        Console.WriteLine(" 1. Display Inventory");
        Console.WriteLine(" 2. Order Inventory");
        Console.WriteLine(" 3. Count Inventory");
        Console.WriteLine(" 4. Simulate Customer Orders");
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }

    public void DisplayInventory(){
        foreach (Product product in _inventory.GetInventory())
            {
                Console.WriteLine(product.GetStringRepresentation());
            }
    }

    public void SaveInventory(){
        using (StreamWriter outputfile = new StreamWriter("inventory.txt", false))
        {
            foreach (Product product in _inventory.GetInventory())
            {
                outputfile.WriteLine(product.GetStringRepresentation());
            }
        }
    }

    public void LoadInventory(){
        string[] lines = File.ReadAllLines("inventory.txt");

        List<Product> newInventory = new();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Product savedProduct = new Product(parts[0], double.Parse(parts[1]), parts[2]);
            newInventory.Add(savedProduct);
        }

        _inventory.SetInventory(newInventory);
    
    }
    
    public void PlaceOrder(){
        OrderInventory order = new();
        order.Order();
        order.UpdateInventory(_inventory.GetInventory());
    }

    public void DoCount(){
        CountInventory count = new();
        count.Count();
        count.CalculateVariance(_inventory.GetInventory());
        Console.Write("Would you like to apply this count? 1.Apply 2. Recount ");
        string choice = Console.ReadLine();

        if (choice == "1"){
            count.UpdateInventory(_inventory.GetInventory());
        }
        else if (choice == "2"){
            DoCount();
        }
            
    }

     public List<Product> CalculateInventory(List<Product> currentInventory, List<MenuItem> itemsOrdered){
        
        foreach (Product product in currentInventory){
            foreach (MenuItem item in itemsOrdered){
                foreach (Product ingredient in item.GetIngredients()){
                    if (ingredient.GetName() == product.GetName()){
                        product.SubQuantity(ingredient.GetQuantity() * item.GetQuantity());
                    }
                }
            }
        }
        return currentInventory;
    }

    public void DoCustomerOrders(){
        CustomerOrder custOrder = new();
        custOrder.simulateRandomOrders();
        custOrder.DisplayItemsOrdered();
        CalculateInventory(_inventory.GetInventory(), custOrder.GetItemsOrdered());
    }
}