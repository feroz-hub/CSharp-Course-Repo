namespace CSharpBasics.Topics;

public static class VariablesDemo
{
    public static void Run()
    {
        // Primitive/value types
        int age = 30;
        double price = 19.99;
        decimal salary = 55000.50m; // high precision for money
        bool isActive = true;
        char grade = 'A';

        // Reference types
        string name = "Ava";
        int[] scores = { 90, 85, 92 };

        // var for local inference (type is still static and known by compiler)
        var city = "London"; // string
        var distanceKm = 12.5; // double

        // const and readonly examples
        const double Pi = 3.14159; // compile-time constant

        Console.WriteLine($"age: {age}, price: {price}, salary: {salary}, isActive: {isActive}, grade: {grade}");
        Console.WriteLine($"name: {name}, city: {city}, distanceKm: {distanceKm}");
        Console.WriteLine($"scores: [{string.Join(", ", scores)}]");
        Console.WriteLine($"Pi: {Pi}");

        // Casting and conversions
        long bigger = age; // implicit widening
        int backToInt = (int)bigger; // explicit cast
        Console.WriteLine($"bigger(long): {bigger}, backToInt: {backToInt}");

        // Nullable types
        int? maybeNumber = null;
        Console.WriteLine($"maybeNumber has value? {maybeNumber.HasValue}");
        maybeNumber ??= 42; // null-coalescing assignment
        Console.WriteLine($"maybeNumber after ??=: {maybeNumber}");
    }
}
