class CountInventory: Inventory{
    private List<Product> _countedInventory = new();

    public override List<Product> UpdateInventory(List<Product>currentInventory){
        int counter = 0;
        foreach (Product product in currentInventory){
            product.SetQuantity(_countedInventory[counter].GetQuantity());
            counter ++;
        }
        return currentInventory;
    }

    public void Count(){
        foreach (Product item in _products){
            Console.Write($"How many {item.GetQuantityType()}s of {item.GetName()} are there? ");
            double itemQuantity = double.Parse(Console.ReadLine());
            Product countedProduct = new Product(item.GetName(), itemQuantity, item.GetQuantityType());
            _countedInventory.Add(countedProduct);
        }
    }

    public void CalculateVariance(List<Product>currentInventory){
        Console.WriteLine($"Inventory variances: ");
        Console.WriteLine("Name: [current], [counted], [variance]");
        int counter = 0;
        foreach (Product product in currentInventory){
            Console.WriteLine($"{product.GetName()}: [{String.Format("{0:0.00}", product.GetQuantity())}], [{String.Format("{0:0.00}",_countedInventory[counter].GetQuantity())}], [{String.Format("{0:0.00}", product.GetQuantity()-_countedInventory[counter].GetQuantity())}]");
        counter++;
        }
    }
}