using CSharpBasics.Topics;

namespace CSharpBasics;

internal class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== C# Basics: Structured Examples ===\n");

        Section("Variables and Primitive Types", VariablesDemo.Run);
        Section("Operators", OperatorsDemo.Run);
        Section("if / if-else / else-if / nested-if", IfStatementsDemo.Run);
        Section("switch-case", SwitchDemo.Run);
        Section("while loop", WhileLoopDemo.Run);
        Section("do-while loop", DoWhileDemo.Run);
        Section("for loop", ForLoopDemo.Run);
        Section("break & continue", BreakContinueDemo.Run);
        Section("nested for loops", NestedLoopsDemo.Run);
        Section("goto (use sparingly)", GotoDemo.Run);

        Console.WriteLine("\nAll sections executed. Press any key to exit...");
        // Don't block if running from automated tools
        if (!Console.IsInputRedirected)
        {
            Console.ReadKey();
        }
    }

    private static void Section(string title, Action body)
    {
        Console.WriteLine($"--- {title} ---");
        body();
        Console.WriteLine();
    }
}
