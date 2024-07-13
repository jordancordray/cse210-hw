
public abstract class Inventory
{
    protected List<Product> _currentInventory = new();

    protected List<Product> _products = [new Product("Large Dough", "Tray"), new Product("Medium Dough", "Tray"), new Product("Small Dough", "Tray"), new Product("Pizza Sauce", "Case"), new Product("Pizza Cheese", "Case"),new Product("Pepperoni", "Case"), new Product("Sausage", "Case"), new Product("Ham", "Case"), new Product("Pineapple", "Bag"), new Product("Mushroom", "Case"), new Product("Black Olives", "Bag"), new Product("Onion", "Bag"), new Product("Green Peppers", "Bag"), new Product("Large Box", "Bundle"), new Product("Medium Box", "Bundle"), new Product("Small Box", "Bundle")];

    public  List<Product> GetInventory(){
        return _currentInventory;
    }

    public void SetInventory(List<Product> newInventory){
        _currentInventory = newInventory;
    }

    public abstract List<Product> UpdateInventory(List<Product> currentInventory);
    
}