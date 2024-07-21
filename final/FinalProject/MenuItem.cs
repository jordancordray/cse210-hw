class MenuItem{
    private string _name;
    private List<Product> _ingredients;
    private int _quantity;

    public MenuItem(string name, List<Product> ingredients){
        _name = name;
        _ingredients = ingredients;
    }
    public MenuItem(string name, List<Product> ingredients, int quantity){
        _name = name;
        _ingredients = ingredients;
        _quantity = quantity;
    }

    public string GetName(){
        return _name;
    }

    public List<Product> GetIngredients(){
        return _ingredients;
    }

     public int GetQuantity(){
        return _quantity;
    }

    public string OrderRepresentation(){
        return $"Name: {_name}; Quantity: {_quantity}";
    }
}
