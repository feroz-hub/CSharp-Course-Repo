namespace CSharpBasics.Topics;

public static class BreakContinueDemo
{
    public static void Run()
    {
        // Find the first even number in a list using break
        int[] numbers = { 1, 3, 7, 10, 11 };
        int? firstEven = null;
        foreach (var n in numbers)
        {
            if (n % 2 == 0)
            {
                firstEven = n;
                break; // stop loop early
            }
        }
        Console.WriteLine($"First even: {firstEven}");

        // Skip negative numbers using continuing
        int[] mixed = { -2, 5, -1, 3 };
        int positiveSum = 0;
        foreach (var n in mixed)
        {
            if (n < 0) continue; // skip the rest of this iteration
            positiveSum += n;
        }
        Console.WriteLine($"Sum of positives: {positiveSum}");
    }
}
