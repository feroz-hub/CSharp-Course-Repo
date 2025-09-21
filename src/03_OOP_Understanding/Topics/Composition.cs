namespace OOP.Understanding.Topics;

// Topic 07: Composition
// Definition: Build complex types by combining simpler ones (has-a relationship).
public static class Composition
{
    public static void Run()
    {
        var engine = new Engine(200);
        var car = new Car(engine);
        Console.WriteLine(car.Description());
        // Exercise: Add a Wheel class and give Car 4 wheels to include in Description().
    }

    public class Engine
    {
        public int HorsePower { get; }
        public Engine(int hp) => HorsePower = hp;
    }

    public class Car
    {
        private readonly Engine _engine; // composed part
        public Car(Engine engine) => _engine = engine;
        public string Description() => $"Car with {_engine.HorsePower} HP engine";
    }
}
