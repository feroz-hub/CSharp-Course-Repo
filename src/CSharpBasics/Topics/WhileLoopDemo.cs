namespace CSharpBasics.Topics;

public static class WhileLoopDemo
{
    public static void Run()
    {
        int count = 3;
        while (count > 0)
        {
            Console.WriteLine($"Countdown: {count}");
            count--; // must change the condition variable to avoid infinite loops
        }
        Console.WriteLine("Blast off!");
    }
}
