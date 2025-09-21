namespace OOP.Understanding.Topics;

// Topic 05: Polymorphism
// Definition: One interface, many implementations; calls resolved by actual object type.
public static class Polymorphism
{
    public static void Run()
    {
        Shape[] shapes = { new Circle(2), new Rectangle(3, 4) };
        foreach (var s in shapes)
        {
            Console.WriteLine($"{s.GetType().Name} area = {s.Area():0.00}");
        }
        // Exercise: Add a Triangle and include in shapes.
    }

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public override double Area() => Math.PI * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        public double W { get; }
        public double H { get; }
        public Rectangle(double w, double h) { W = w; H = h; }
        public override double Area() => W * H;
    }
}
