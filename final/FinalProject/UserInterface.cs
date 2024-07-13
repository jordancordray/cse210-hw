using System.Runtime.InteropServices;

class UserInterface{
    private Inventory _inventory = new currentInventory();

    // private List<string> _reports;

    public string Menu(){
        Console.WriteLine($"Welcome to the Inventory app!");
        Console.WriteLine("\nMenu options: ");
        Console.WriteLine(" 0. Quit");
        Console.WriteLine(" 1. Display Inventory");
        Console.WriteLine(" 2. Order Inventory");
        Console.WriteLine(" 3. Count Inventory");
        Console.WriteLine(" 4. ");
        Console.WriteLine(" 5. ");
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
        count.UpdateInventory(_inventory.GetInventory());
    }
}