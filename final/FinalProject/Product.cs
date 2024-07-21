
public class Product {
    private string _name;
    private double _quantity;
    private string _quantityType;


    public Product(string name, string type){
        _name = name;
        _quantityType = type;
    }
    public Product(string name, double quantity, string type){
        _name = name;
        _quantity = quantity;
        _quantityType = type;
    }

    public string GetName(){
        return _name;
    }

    public double GetQuantity(){
        return _quantity;
    }

    public string GetQuantityType(){
        return _quantityType;
    }

    public string GetStringRepresentation(){
        return $"{_name},{String.Format("{0:0.00}", _quantity)},{_quantityType}";
    }

    public void AddQuantity(double addedQuantity){
        _quantity += addedQuantity;
    }

    public void SubQuantity(double SubbedQuantity){
        _quantity -= SubbedQuantity;
    }

    public void SetQuantity(double newQuantity){
        _quantity = newQuantity;
    }

}