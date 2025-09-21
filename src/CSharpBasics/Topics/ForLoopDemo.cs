namespace CSharpBasics.Topics;

public static class ForLoopDemo
{
    public static void Run()
    {
        // Sum first 5 natural numbers
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum 1..5 = {sum}");

        // Iterate arrays
        string[] names = { "Ada", "Bob", "Cleo" };
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Index {i}: {names[i]}");
        }

        // foreach (not requested but useful)
        Console.Write("Uppercase: ");
        foreach (var n in names)
        {
            Console.Write(n.ToUpperInvariant() + " ");
        }
        Console.WriteLine();
    }
}
