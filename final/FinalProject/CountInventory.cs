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
}