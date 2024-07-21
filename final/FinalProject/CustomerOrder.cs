class CustomerOrder{
    private List<MenuItem> _Menu;
    private List<MenuItem> _itemsOrdered;

    public CustomerOrder(){
        _Menu = new();
        string[] lines = File.ReadAllLines("menuitems.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string[] ingredients = parts[1].Split(";");
            List<Product>ingredientsList = new();
            foreach (string ingredient in ingredients){
                string[] details = ingredient.Split(",");
                Product newProduct = new Product(details[0],double.Parse(details[1]),details[2]);
                ingredientsList.Add(newProduct);
            }
            MenuItem newMenuItem = new MenuItem(parts[0], ingredientsList);
           _Menu.Add(newMenuItem);
        }
    }

    public void simulateRandomOrders(){
        _itemsOrdered = new();

        Random rand = new Random();
        
        foreach(MenuItem menuItem in _Menu){
            int randomQuantity = rand.Next(10,50);
            MenuItem newMenuItem = new MenuItem(menuItem.GetName(), menuItem.GetIngredients(), randomQuantity);
            _itemsOrdered.Add(newMenuItem);
        }
    }

    public List<MenuItem> GetItemsOrdered(){
        return _itemsOrdered;
    }

    public void DisplayItemsOrdered(){
        Console.WriteLine("Items Ordered: ");
        foreach(MenuItem menuItem in _itemsOrdered){
            Console.WriteLine(menuItem.OrderRepresentation());
        }
    }
}