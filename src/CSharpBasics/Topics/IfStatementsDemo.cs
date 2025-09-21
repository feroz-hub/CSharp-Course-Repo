namespace CSharpBasics.Topics;

public static class IfStatementsDemo
{
    public static void Run()
    {
        int temperature = 28;

        // Simple if
        if (temperature > 25)
        {
            Console.WriteLine("It's warm outside.");
        }

        // if-else
        if (temperature >= 30)
        {
            Console.WriteLine("It's hot.");
        }
        else
        {
            Console.WriteLine("Not too hot.");
        }

        // else-if chain
        if (temperature < 0)
        {
            Console.WriteLine("Freezing");
        }
        else if (temperature < 15)
        {
            Console.WriteLine("Chilly");
        }
        else if (temperature < 25)
        {
            Console.WriteLine("Mild");
        }
        else
        {
            Console.WriteLine("Warm+ ");
        }

        // Nested-if: categorize score
        int score = 87;
        if (score >= 60)
        {
            if (score >= 85)
            {
                Console.WriteLine("Passed with distinction");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
}
