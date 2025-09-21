namespace CSharpBasics.Topics;

public static class NestedLoopsDemo
{
    public static void Run()
    {
        // Multiplication table 1..3
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write($"{i}x{j}={(i * j),2}  ");
            }
            Console.WriteLine();
        }
    }
}
