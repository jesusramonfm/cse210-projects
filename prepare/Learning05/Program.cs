using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Squaer object
        Square square1 =  new Square("red", 10);
        Console.WriteLine($"Color {square1.GetColor()}");
        Console.WriteLine($"Area {square1.GetArea()}\n");

        // Creating a Rectangle object
        Rectangle rectangle1 =  new Rectangle("blue", 10, 5);
        Console.WriteLine($"Color {rectangle1.GetColor()}");
        Console.WriteLine($"Area {rectangle1.GetArea()}\n");
        
        // Creating a Circle object
        Circle circle1 =  new Circle("yellow", 9);
        Console.WriteLine($"Color {circle1.GetColor()}");
        Console.WriteLine($"Area {circle1.GetArea()}\n");

        List<Shape> shapes = new List<Shape>{};
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color {shape.GetColor()}");
            Console.WriteLine($"Area {shape.GetArea()}\n");
        }
    }
}