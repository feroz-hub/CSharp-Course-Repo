# Basics of C# — Beginner Friendly

C# (pronounced "see sharp") is a modern, object‑oriented programming language widely used with .NET to build web, desktop, cloud, games (Unity), and tools. This guide teaches the essential C# you need to get started quickly.

---

## 1) Your first C# program (Hello World)

- Install the .NET SDK from: https://dotnet.microsoft.com/download
- Create a console app and run it:
```
dotnet new console -n HelloCSharp
cd HelloCSharp
dotnet run
```
- The template creates Program.cs. A minimal Program.cs might look like:

```csharp
Console.WriteLine("Hello, C#");
```

Tip: In modern .NET templates, top‑level statements are used (no explicit Main method needed). Both styles are valid.

---

## 2) Variables and types

- Value types: int, double, bool, char, struct, enum
- Reference types: string, class, interface, array, object, record
- Use `var` for local type inference when the type is obvious.

```csharp
int age = 25;
var price = 9.99;          // double
bool isActive = true;
string name = "Ava";       // string is reference type but immutable
char grade = 'A';

// Constants
const double Pi = 3.14159;
```

### Numeric literals and conversions
```csharp
int a = 1_000_000;      // underscores for readability
long big = a;           // implicit widening
int small = (int)big;   // explicit cast (may lose data)
```

---

## 3) Operators (quick glance)

- Arithmetic: `+ - * / %`
- Comparison: `== != < <= > >=`
- Logical: `&& || !`
- Null‑coalescing: `??` and `??=`
- Null‑conditional: `?.` and `?[]`
- String interpolation: `$"Hello {name}"`

```csharp
string? input = null;
string text = input ?? "default";   // if input is null, use "default"
int? len = input?.Length;            // safe access (null if input is null)
```

---

## 4) Control flow

```csharp
int score = 87;
if (score >= 90)
    Console.WriteLine("A");
else if (score >= 80)
    Console.WriteLine("B");
else
    Console.WriteLine("C or below");

// switch expression (concise)
var grade = score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    _     => "D/F"
};
Console.WriteLine(grade);

// loops
for (int i = 0; i < 3; i++) Console.WriteLine(i);

int n = 3;
while (n > 0)
{
    Console.WriteLine(n);
    n--;
}

int[] data = { 1, 2, 3 };
foreach (var x in data) Console.WriteLine(x);
```

---

## 5) Methods (functions)

```csharp
int Add(int x, int y) => x + y;     // expression‑bodied method

void Greet(string name = "World")   // default parameter
{
    Console.WriteLine($"Hello {name}");
}

// Named arguments
var total = Add(y: 5, x: 2);
Greet();
Greet("Ava");
```

- Pass by reference (advanced): `ref`, `out`, `in` exist when necessary.

---

## 6) Classes and objects (OOP)

```csharp
public class Person
{
    // Auto‑property with initializer
    public string Name { get; set; } = "Unknown";

    // Read‑only property
    public int BirthYear { get; }

    // Field (usually keep private)
    private int _visits;

    // Constructor
    public Person(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }

    // Method
    public int AgeIn(int year) => year - BirthYear;

    // Static member
    public static Person CreateAnonymous() => new("Anon", DateTime.Now.Year);
}

var p = new Person("Sam", 2000);
Console.WriteLine(p.Name);
Console.WriteLine(p.AgeIn(2025));
var anon = Person.CreateAnonymous();
```

### Records (for data models)
- Records provide value‑based equality and concise syntax.
```csharp
public record Product(int Id, string Name, decimal Price);
var prod1 = new Product(1, "Pen", 1.50m);
var prod2 = prod1 with { Price = 1.75m }; // non‑destructive mutation
```

### Structs vs Classes
- class = reference type (heap, GC, passed by reference semantics)
- struct = value type (stack/inline, copied by value) — use for small, immutable data.

### Enums
```csharp
enum Status { New, InProgress, Done }
Status s = Status.New;
```

---

## 7) Namespaces and using

```csharp
namespace MyApp.Models;

public class Order { }
```

- Use file‑scoped namespace (`namespace X;`) to reduce indentation.
- `using` imports namespaces:
```csharp
using System;
using System.Collections.Generic;
```

---

## 8) Collections

```csharp
int[] nums = { 1, 2, 3 };           // fixed size
var list = new List<int> { 1, 2, 3 }; // dynamic
var dict = new Dictionary<string, int>
{
    ["apples"] = 3,
    ["oranges"] = 2
};

list.Add(4);
Console.WriteLine(dict["apples"]);  // 3
```

### LINQ (query your data)
```csharp
using System.Linq;

var evens = list.Where(x => x % 2 == 0).Select(x => x * x).ToList();
Console.WriteLine(string.Join(", ", evens));
```

---

## 9) Exceptions and resource cleanup

```csharp
try
{
    int x = int.Parse("not a number");
}
catch (FormatException ex)
{
    Console.WriteLine($"Invalid number: {ex.Message}");
}

// using statement ensures IDisposable is cleaned up
using var file = new StreamWriter("out.txt");
file.WriteLine("Hello");
```

---

## 10) Nullability and safety

- Enable nullable reference types in your project (on by default in modern SDKs):
  - In .csproj: `<Nullable>enable</Nullable>`
- Use `?` for nullable reference/value types and operators `?.`, `??`, `??=` for safety.

```csharp
string? maybeName = null;
maybeName ??= "Guest";
Console.WriteLine(maybeName.Length); // safe: not null after ??=
```

Avoid the null‑forgiving operator `!` unless you’re certain a value is not null.

---

## 11) Async/await (intro)

```csharp
using System.Net.Http;

var http = new HttpClient();
string html = await http.GetStringAsync("https://example.com");
Console.WriteLine(html.Length);
```

- Methods using `await` must be `async`:
```csharp
public static async Task<int> FetchLengthAsync(string url)
{
    using var http = new HttpClient();
    var html = await http.GetStringAsync(url);
    return html.Length;
}
```

---

## 12) Coding conventions (quick)

- PascalCase for public types/members: `MyClass`, `TotalCount`
- camelCase for locals/parameters: `totalCount`
- Use meaningful names, prefer `var` when the type is obvious.
- Keep classes small and focused; prefer immutability when possible.

Microsoft style guide: https://learn.microsoft.com/dotnet/csharp/fundamentals/coding-style/coding-conventions

---

## 13) Mini exercises

- Write a method to check if a number is prime.
- Parse a CSV line into a record and print fields.
- Given a list of numbers, use LINQ to get the top 3 even squares.
- Create a Person class with Name and Age, then filter adults (Age >= 18).

---

## 14) Summary

- C# is a modern, type‑safe, object‑oriented language.
- Learn the basics: types, control flow, methods, classes, collections, exceptions.
- Embrace nullability, LINQ, and async for robust, modern code.
- Practice with small console apps and grow into web (ASP.NET Core) or other app types.
