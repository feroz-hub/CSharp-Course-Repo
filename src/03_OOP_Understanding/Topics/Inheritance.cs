namespace OOP.Understanding.Topics;

// Topic 04: Inheritance
// Definition: Derive new classes from existing ones to reuse and extend behavior.
public static class Inheritance
{
    public static void Run()
    {
        Animal a = new Dog("Rex");
        Console.WriteLine(a.Speak());
        // Exercise: Create a Cat class deriving Animal, override Speak to return "Meow".
    }

    public abstract class Animal
    {
        public string Name { get; }
        protected Animal(string name) => Name = name;
        public virtual string Speak() => "..."; // base behavior
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override string Speak() => $"{Name}: Woof";
    }
}
