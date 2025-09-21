namespace CSharpBasics.Topics;

public static class DoWhileDemo
{
    public static void Run()
    {
        int attempts = 0;
        string secret = "ok";
        string input;
        do
        {
            attempts++;
            input = attempts < 2 ? "no" : "ok"; // pretend user typed
            Console.WriteLine($"Attempt {attempts}, input = '{input}'");
        } while (input != secret && attempts < 3);

        Console.WriteLine("Loop ended.");
    }
}
