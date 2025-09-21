namespace OOP.Understanding.Topics;

// Topic 03: Abstraction
// Definition: Show essential features and hide unnecessary details.
public static class Abstraction
{
    public static void Run()
    {
        Device phone = new Smartphone();
        phone.TurnOn();
        Console.WriteLine(phone.Status());
        // Exercise: Create a new concrete Device (e.g., Laptop) and override abstract members.
    }

    public abstract class Device
    {
        private bool _isOn;
        public void TurnOn() => _isOn = true; // common logic
        public void TurnOff() => _isOn = false;
        public string Status() => _isOn ? "On" : "Off";
        public abstract string Model { get; }
    }

    public class Smartphone : Device
    {
        public override string Model => "Smartphone X";
    }
}
