namespace OOP.Understanding.Topics;

// Topic 09: Static Members
// Definition: Static members belong to the type itself, not to instances.
public static class StaticMembers
{
    public static void Run()
    {
        var u1 = new User("Ava");
        var u2 = new User("Ben");
        Console.WriteLine($"Users created: {User.Count}");
        Console.WriteLine(u1.Name + ", " + u2.Name);
        // Exercise: Add a static Parse method to create a User from "Name" string.
    }

    public class User
    {
        public static int Count { get; private set; }
        public string Name { get; }
        static User() { Count = 0; } // static ctor
        public User(string name)
        {
            Name = name;
            Count++;
        }
    }
}
