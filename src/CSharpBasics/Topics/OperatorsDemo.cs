namespace CSharpBasics.Topics;

public static class OperatorsDemo
{
    public static void Run()
    {
        int a = 7, b = 3;
        Console.WriteLine($"a={a}, b={b}");

        // Arithmetic
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a - b = {a - b}");
        Console.WriteLine($"a * b = {a * b}");
        Console.WriteLine($"a / b = {a / b} (integer division)");
        Console.WriteLine($"a % b = {a % b}");

        // Comparison
        Console.WriteLine($"a == b? {a == b}");
        Console.WriteLine($"a != b? {a != b}");
        Console.WriteLine($"a > b? {a > b}");
        Console.WriteLine($"a <= b? {a <= b}");

        // Logical
        bool sunny = true, weekend = false;
        Console.WriteLine($"sunny && weekend = {sunny && weekend}");
        Console.WriteLine($"sunny || weekend = {sunny || weekend}");
        Console.WriteLine($"!sunny = {!sunny}");

        // Null-coalescing and null-conditional
        string? maybeName = null;
        Console.WriteLine($"maybeName?.Length = {maybeName?.Length}");
        Console.WriteLine($"maybeName ?? \"guest\" = {maybeName ?? "guest"}");

        // String interpolation
        var x = 2; var y = 5;
        Console.WriteLine($"{x} + {y} = {x + y}");
    }
}
