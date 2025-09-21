# OOP in C# — A Friendly Guide for Beginners

Object-Oriented Programming (OOP) is a way of writing programs by modeling real-world things as objects that contain data and behavior.

Why it matters: OOP helps you build larger, cleaner, and more maintainable software. It organizes code so it’s easier to reuse, test, change, and extend — which is exactly what real-world projects need.

---

## Core Concepts (in the order you should learn them)

- Classes and Objects
- Encapsulation
- Abstraction
- Inheritance
- Polymorphism

---

## 1) Classes and Objects

### Definition
A class is a blueprint; an object is a real thing built from that blueprint.

### Explanation
- A class defines what data (fields/properties) and actions (methods) an object will have. Think of a class like a blueprint for a house.
- An object is an instance of a class — a specific house built from the blueprint, with its own state.

Real-world analogy: "Car" is a class (blueprint). Your specific car — a blue Honda made in 2019 — is an object (instance).

### C# Code Example
```csharp
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void Honk()
    {
        Console.WriteLine("Beep!");
    }
}

// Usage
var myCar = new Car { Make = "Honda", Model = "Civic", Year = 2019 };
myCar.Honk(); // Beep!
```

### Simple Diagram
```
Class: Car
 ├── Properties: Make, Model, Year
 └── Methods: Honk()

Object: myCar (Car)
 ├── Make = "Honda"
 ├── Model = "Civic"
 └── Year = 2019
```

### Key Takeaways
- ✅ A class describes structure and behavior; an object is a live instance.
- ✅ You can create many objects from one class.
- ✅ Each object has its own data (state).

---

## 2) Encapsulation

### Definition
Encapsulation means bundling data and methods together and restricting direct access to some of the object’s parts.

### Explanation
- In C#, we use access modifiers like private, public, and protected to control what can be accessed from outside.
- Encapsulation protects the object’s internal state and ensures changes happen in controlled ways (through methods or properties).

Real-world analogy: A TV remote has buttons (public) but hides the complex circuits inside (private). You can use it without opening it.

### C# Code Example
```csharp
public class BankAccount
{
    // Field is private: cannot be changed directly from outside
    private decimal _balance;

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");
        _balance = initialBalance;
    }

    public decimal GetBalance() => _balance; // Read-only access

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Amount must be positive.");
        _balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0) return false;
        if (amount > _balance) return false; // Prevent invalid state
        _balance -= amount;
        return true;
    }
}
```

### Simple Diagram
```
BankAccount
 ├── private: _balance
 ├── public: GetBalance()
 ├── public: Deposit(amount)
 └── public: Withdraw(amount)
```

### Key Takeaways
- ✅ Encapsulation hides details and exposes safe operations.
- ✅ Use access modifiers (private/public) to protect state.
- ✅ Changes go through controlled methods or properties.

---

## 3) Abstraction

### Definition
Abstraction focuses on what an object does rather than how it does it.

### Explanation
- In C#, abstraction often uses interfaces or abstract classes to define behavior without providing full implementation.
- It lets you think at a higher level and swap implementations without changing the rest of the code.

Real-world analogy: When you drive, you use the steering wheel and pedals (what), without caring about the engine’s internal combustion process (how).

### C# Code Example
```csharp
public interface IPaymentProcessor
{
    void Pay(decimal amount);
}

public class CardPaymentProcessor : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} with card.");
    }
}

public class CryptoPaymentProcessor : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} with crypto.");
    }
}

// Usage (code depends on the abstraction, not the concrete class)
IPaymentProcessor processor = new CardPaymentProcessor();
processor.Pay(50m);
```

### Simple Diagram
```
IPaymentProcessor (interface)
 └── Pay(amount)

Implementations:
 ├── CardPaymentProcessor : IPaymentProcessor
 └── CryptoPaymentProcessor : IPaymentProcessor
```

### Key Takeaways
- ✅ Abstraction defines contracts (interfaces/abstract classes).
- ✅ Code uses the contract, not the concrete type.
- ✅ Easier to change implementations without breaking users.

---

## 4) Inheritance

### Definition
Inheritance lets one class reuse and extend another class’s behavior.

### Explanation
- A derived class (child) inherits from a base class (parent) and can add new members or override virtual ones.
- Inheritance promotes reuse but should model an "is-a" relationship (e.g., Dog is a Animal).

Real-world analogy: A "Smartphone" is a kind of "Phone" but with extra capabilities.

### C# Code Example
```csharp
public class Animal
{
    public string Name { get; set; }
    public virtual void Speak() => Console.WriteLine("(silence)");
}

public class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof!");
}

// Usage
var pet = new Dog { Name = "Rex" };
pet.Speak(); // Woof!
```

### Simple Diagram
```
Animal (base)
 ├── Name
 └── virtual Speak()
      ↑ override
Dog (derived)
 └── override Speak()
```

### Key Takeaways
- ✅ Use inheritance for clear "is-a" relationships.
- ✅ Derived classes can override virtual methods.
- ✅ Prefer composition over inheritance when relationships aren’t strict.

---

## 5) Polymorphism

### Definition
Polymorphism lets a single interface or base type represent many forms (different concrete behaviors).

### Explanation
- With polymorphism, you can call the same method on different types and get type-specific behavior.
- In C#, this is achieved via virtual/override (inheritance) or via interfaces.

Real-world analogy: A “Play()” method on instruments — Guitar, Piano, and Flute each produce different sounds when you call the same method.

### C# Code Example
```csharp
public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; }
    public Circle(double radius) => Radius = radius;
    public override double Area() => Math.PI * Radius * Radius;
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }
    public Rectangle(double width, double height) { Width = width; Height = height; }
    public override double Area() => Width * Height;
}

// Usage
Shape s1 = new Circle(2);
Shape s2 = new Rectangle(3, 4);
Console.WriteLine(s1.Area()); // Uses Circle.Area
Console.WriteLine(s2.Area()); // Uses Rectangle.Area
```

### Simple Diagram
```
Shape (abstract)
 └── abstract Area()
     ↑ overrides
 ├── Circle : Shape
 │    └── Area() => πr²
 └── Rectangle : Shape
      └── Area() => w×h
```

### Key Takeaways
- ✅ Same call, different behavior depending on runtime type.
- ✅ Achieved via virtual/override, abstract methods, or interfaces.
- ✅ Enables flexible, extensible designs.

---

## Comparisons & Clarifications

### Encapsulation vs Abstraction
- Encapsulation is about "hiding the data and the inner workings" by controlling access. It bundles data + operations and protects state.
- Abstraction is about "exposing only what matters" (the essential features) and hiding unnecessary details by defining contracts.

Tiny example:
```csharp
// Encapsulation: hide fields, expose safe methods
public class Thermostat
{
    private double _temperature;
    public void SetTemperature(double value)
    {
        if (value < 10 || value > 30)
            throw new ArgumentOutOfRangeException();
        _temperature = value;
    }
    public double GetTemperature() => _temperature;
}

// Abstraction: the interface specifies WHAT operations exist
public interface ITemperatureControl
{
    void HeatOn();
    void HeatOff();
}
```

### Overloading vs Overriding
- Overloading: same method name, different parameter lists in the same class.
- Overriding: redefining a virtual/abstract method in a derived class to change behavior.

Examples:
```csharp
// Overloading (compile-time)
public class MathUtil
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b; // same name, different signature
}

// Overriding (runtime)
public class Printer
{
    public virtual void Print() => Console.WriteLine("Base print");
}

public class FancyPrinter : Printer
{
    public override void Print() => Console.WriteLine("Fancy print");
}
```

---

## Real-world Mini Example: Vehicle Fleet (Combining All Principles)

Goal: Model a fleet where we can add different vehicle types and calculate trips. We’ll show encapsulation, abstraction (interfaces), inheritance, and polymorphism.

### Design
- Abstraction: IDrive defines how a vehicle drives.
- Inheritance: Car and Truck inherit from Vehicle.
- Encapsulation: Fuel and odometer are managed through controlled methods.
- Polymorphism: A list of Vehicle uses overridden methods.

### Code
```csharp
public interface IDrive
{
    void Drive(double kilometers);
}

public abstract class Vehicle : IDrive
{
    public string Plate { get; }
    private double _odometer;     // encapsulated state
    private double _fuel;         // encapsulated state (liters)

    protected Vehicle(string plate, double initialFuel)
    {
        Plate = plate;
        _fuel = initialFuel;
        _odometer = 0;
    }

    public double Odometer => _odometer; // read-only
    public double Fuel => _fuel;         // read-only

    protected abstract double FuelConsumptionPerKm { get; } // liters/km

    public virtual void Refuel(double liters)
    {
        if (liters <= 0) throw new ArgumentException("Must be positive");
        _fuel += liters;
    }

    public void Drive(double kilometers)
    {
        if (kilometers <= 0) return;
        double required = kilometers * FuelConsumptionPerKm;
        if (required > _fuel)
            throw new InvalidOperationException("Not enough fuel");
        _fuel -= required;
        _odometer += kilometers;
    }

    public abstract void Honk();
}

public class Car : Vehicle
{
    public Car(string plate, double initialFuel) : base(plate, initialFuel) {}
    protected override double FuelConsumptionPerKm => 0.07; // 7L/100km
    public override void Honk() => Console.WriteLine("Beep!");
}

public class Truck : Vehicle
{
    public Truck(string plate, double initialFuel) : base(plate, initialFuel) {}
    protected override double FuelConsumptionPerKm => 0.15; // 15L/100km
    public override void Honk() => Console.WriteLine("HOOOONK!");
}

// Usage
var vehicles = new List<Vehicle>
{
    new Car("AB-123", 30),
    new Truck("CD-456", 100)
};

foreach (var v in vehicles)
{
    v.Drive(100);  // polymorphic: same call, type-specific fuel use
    v.Honk();      // polymorphic
    Console.WriteLine($"{v.Plate}: {v.Odometer} km, Fuel left: {v.Fuel} L");
}
```

### Simple Diagram
```
IDrive (interface)
 └── Drive(km)

Vehicle (abstract) : IDrive
 ├── Plate
 ├── private _odometer, _fuel
 ├── abstract FuelConsumptionPerKm
 ├── Refuel(l)
 ├── Drive(km)
 └── abstract Honk()
     ↑ overrides
 ├── Car : Vehicle
 │    ├── FuelConsumptionPerKm = 0.07
 │    └── Honk() => "Beep!"
 └── Truck : Vehicle
      ├── FuelConsumptionPerKm = 0.15
      └── Honk() => "HOOOONK!"
```

### Why OOP Helps Here
- 🔑 Clean separation of concerns: vehicles share logic (Vehicle), specifics live in subclasses.
- 🔑 Extensible: add Motorcycle by creating a new class; existing code still works.
- 🔑 Safe state: fuel/odometer are protected by methods (encapsulation).
- 🔑 Polymorphism: one list holds different vehicle types and still behaves correctly.

---

## Quick Recap
- ✅ Classes/Objects model real things.
- ✅ Encapsulation protects data and groups behavior.
- ✅ Abstraction focuses on what, not how (interfaces/contracts).
- ✅ Inheritance reuses and specializes behavior.
- ✅ Polymorphism lets the same call do different things.

Keep practicing by modeling tiny domains (library books, bank accounts, to-do tasks). Write small examples, then refactor toward interfaces and base classes as your needs grow. OOP will start to feel natural as you see how it keeps code clean and change-friendly.
