using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

class Square : Shape {
    private double _side;

    public Square(double side, string color) : base(color){
        _side = side;
    }

    public override double GetArea(){
        return _side * _side;
    }
}