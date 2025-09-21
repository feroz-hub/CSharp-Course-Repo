using OOP.Understanding.Topics;

namespace OOP.Understanding;

internal class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== 03_OOP_Understanding ===\n");
        Console.WriteLine("This project teaches core OOP concepts with tiny, clear examples.\n" +
                          "Open each topic file to read comments and exercises (TODOs).\n");

        Run("01. Classes & Objects", ClassesObjects.Run);
        Run("02. Encapsulation", Encapsulation.Run);
        Run("03. Abstraction", Abstraction.Run);
        Run("04. Inheritance", Inheritance.Run);
        Run("05. Polymorphism", Polymorphism.Run);
        Run("06. Interfaces", Interfaces.Run);
        Run("07. Composition", Composition.Run);
        Run("08. Constructors & Destructors", CtorsDestructors.Run);
        Run("09. Static Members", StaticMembers.Run);
        Run("10. Properties & Access Modifiers", PropertiesAccess.Run);
        Run("11. Overloading vs Overriding", OverloadOverride.Run);
        Run("12. ref / out / readonly", RefOutReadonly.Run);
        Run("13. Generics in OOP", GenericsOop.Run);

        Console.WriteLine("\nAll topics executed. You can run unit tests for practice.\n");
        if (!Console.IsInputRedirected)
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    private static void Run(string title, Action action)
    {
        Console.WriteLine($"--- {title} ---");
        action();
        Console.WriteLine();
    }
}
