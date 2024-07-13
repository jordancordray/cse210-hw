
class OrderInventory: Inventory{
    private List<Product> _orderedInventory = new();

    public override List<Product> UpdateInventory(List<Product> currentInventory){
        int counter = 0;
        foreach (Product product in currentInventory){
            product.AddQuantity(_orderedInventory[counter].GetQuantity());
            counter ++;
        }

        return currentInventory;
    }

    public void Order(){
        foreach (Product item in _products){
            Console.Write($"How many {item.GetQuantityType()}s of {item.GetName()} would you like to order? ");
            double itemQuantity = double.Parse(Console.ReadLine());
            Product orderedProduct = new Product(item.GetName(), itemQuantity, item.GetQuantityType());
            _orderedInventory.Add(orderedProduct);
        }
    }
}