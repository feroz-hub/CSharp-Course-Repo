namespace OOP.Understanding.Topics;

// Topic 11: Overloading vs Overriding
// Definition: Overloading = same name, different parameters (compile-time). Overriding = replacing base virtual method (runtime).
public static class OverloadOverride
{
    public static void Run()
    {
        var calc = new Calculator();
        Console.WriteLine(calc.Add(2, 3));
        Console.WriteLine(calc.Add(2.5, 3.5));

        Base b = new Derived();
        Console.WriteLine(b.Greet()); // calls Derived override
        // Exercise: Add another overload Add(int a, int b, int c).
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b; // overload 1
        public double Add(double a, double b) => a + b; // overload 2
    }

    public class Base
    {
        public virtual string Greet() => "Hello from Base";
    }

    public class Derived : Base
    {
        public override string Greet() => "Hello from Derived";
    }
}
