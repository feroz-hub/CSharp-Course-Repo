namespace OOP.Understanding.Topics;

// Topic 06: Interfaces
// Definition: Interfaces define contracts (what), classes implement them (how).
public static class Interfaces
{
    public static void Run()
    {
        ILogger logger = new ConsoleLogger();
        logger.Log("Interface demo");
        // Exercise: Implement a FileLogger that writes to a file (hint: use System.IO).
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
