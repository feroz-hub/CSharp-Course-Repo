namespace CSharpBasics.Topics;

public static class GotoDemo
{
    public static void Run()
    {
        // Note: goto should generally be avoided in C#; the structured control flow is clearer.
        // This example shows using goto to jump to a label on a special condition.
        int[] values = { 1, 3, 5, 7, 9, 10, 11 };
        int i = 0;

        Start:
        if (i >= values.Length) goto End;
        int current = values[i];
        Console.WriteLine($"Value[{i}] = {current}");
        if (current % 2 == 0) goto FoundEven;
        i++;
        goto Start;

        FoundEven:
        Console.WriteLine($"Found even number: {current} at index {i}");

        End:
        Console.WriteLine("goto demo finished");
    }
}
