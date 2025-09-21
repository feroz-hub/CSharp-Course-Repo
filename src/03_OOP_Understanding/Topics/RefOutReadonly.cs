namespace OOP.Understanding.Topics;

// Topic 12: ref / out / readonly
// Definition: ref passes by reference; out outputs via parameter; readonly prevents modification after initialization.
public static class RefOutReadonly
{
    public static void Run()
    {
        int a = 5;
        DoubleInPlace(ref a);
        Console.WriteLine($"a after ref: {a}");

        if (TryParsePositive("42", out int value))
        {
            Console.WriteLine($"Parsed: {value}");
        }

        var p = new ReadonlyPoint(3, 4);
        Console.WriteLine($"Point: {p.X}, {p.Y}");
        // p.X = 10; // not allowed (readonly)
    }

    public static void DoubleInPlace(ref int x) => x *= 2;

    public static bool TryParsePositive(string s, out int val)
    {
        if (int.TryParse(s, out val) && val >= 0) return true;
        val = 0; return false;
    }

    public readonly struct ReadonlyPoint
    {
        public int X { get; }
        public int Y { get; }
        public ReadonlyPoint(int x, int y) { X = x; Y = y; }
    }
}
