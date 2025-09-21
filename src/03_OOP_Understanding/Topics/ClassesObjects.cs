namespace OOP.Understanding.Topics;

// Topic 01: Classes & Objects
// Definition: A class defines a blueprint; an object is an instance of that blueprint.
public static class ClassesObjects
{
    public static void Run()
    {
        var player = new Player("Ava", 100);
        player.TakeDamage(25);
        Console.WriteLine(player.GetStatus());
        // Exercise: Create another class Book with Title, Author and a method Describe() returning "Title by Author".
        // Instantiate and print the description here.
    }

    // Simple class with fields, constructor and methods
    public class Player
    {
        public string Name; // later we will encapsulate into properties
        public int Health;

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public string GetStatus() => $"{Name} has {Health} HP";
    }
}
