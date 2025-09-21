namespace OOP.Understanding.Topics;

// Topic 10: Properties & Access Modifiers
// Definition: Properties expose data safely; access modifiers control visibility.
public static class PropertiesAccess
{
    public static void Run()
    {
        var p = new Person("Ava", 30);
        p.Age = 31; // ok via property
        // p._age = -5; // not allowed (private)
        Console.WriteLine(p);
        // Exercise: Make Name settable only inside the class (private setter). Done below.
    }

    public class Person
    {
        public string Name { get; private set; }
        private int _age;
        public int Age
        {
            get => _age;
            set => _age = value < 0 ? 0 : value; // simple validation
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() => $"{Name} ({Age})";
    }
}
