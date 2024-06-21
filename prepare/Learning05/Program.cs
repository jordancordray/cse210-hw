using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        Square newSquare = new(10, "green");
        shapes.Add(newSquare);

        Rectangle newRectangle = new(10, 20, "blue");
        shapes.Add(newRectangle);

        Circle newCircle = new(5, "red");
        shapes.Add(newCircle);

        foreach (Shape shape in shapes){
            double area = shape.GetArea();

            string color = shape.GetColor();
            

            Console.WriteLine($"The shape is {color} and has an area of {area}.");
        }
        
    }
}