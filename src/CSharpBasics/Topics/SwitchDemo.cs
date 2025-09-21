namespace CSharpBasics.Topics;

public static class SwitchDemo
{
    public static void Run()
    {
        string day = "Mon";

        // Traditional switch statement
        switch (day)
        {
            case "Mon":
            case "Tue":
            case "Wed":
            case "Thu":
                Console.WriteLine("Weekday: Work day");
                break;
            case "Fri":
                Console.WriteLine("Weekday: Lighter work day");
                break;
            case "Sat":
            case "Sun":
                Console.WriteLine("Weekend: Rest");
                break;
            default:
                Console.WriteLine("Unknown day");
                break;
        }

        // Modern switch expression
        int month = 2;
        int days = month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => 28, // ignoring leap years for simplicity
            _ => 0
        };
        Console.WriteLine($"Days in month {month}: {days}");
    }
}
