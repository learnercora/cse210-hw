using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        // //Square square = new Square(5,"red");
        // //Circle circle = new Circle(5,"red");
        // Rectangle rectangle = new Rectangle(5,4,"red");
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(5,"red"));
        shapes.Add(new Rectangle(5,4,"green"));
        shapes.Add(new Circle(3,"blue"));

        // Get a custom calculation for each one
        foreach(Shape shape in shapes)
        {
            double area = shape.GetArea();
            //Console.WriteLine(area);
            string color = shape.GetColor();
            //Console.WriteLine(color);
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}