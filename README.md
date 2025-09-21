# CSharp Course Repo

A hands-on learning repository for C# and .NET. It contains two runnable console projects with small, focused examples and a test suite you can use for practice:

- src/CSharpBasics — language fundamentals (variables, operators, control flow, loops, etc.)
- src/03_OOP_Understanding — object-oriented programming concepts (classes, encapsulation, inheritance, polymorphism, interfaces, generics, and more)
- tests/03_OOP_Understanding.Tests — xUnit tests to reinforce OOP concepts
- docs — curated notes that accompany the code samples

## Prerequisites
- .NET SDK 8.0 or later
- Any editor/IDE (JetBrains Rider, Visual Studio, or VS Code)

Check your .NET version:

```
 dotnet --version
```

## Getting Started
Clone the repo and restore/build once:

```
 git clone <this-repo-url>
 cd CSharp-Course-Repo
 dotnet restore
 dotnet build
```

## Run the Samples
Run the C# basics project:

```
 dotnet run --project src/CSharpBasics
```

Run the OOP understanding project:

```
 dotnet run --project src/03_OOP_Understanding
```

Both apps print section titles and example outputs to the console. Many topic files contain short exercises (comments with TODOs). Open the corresponding file under src to implement them.

## Run Tests
The test project uses xUnit + FluentAssertions.

- Run all tests:
```
dotnet test
```

- Run only the OOP tests project:
```
dotnet test tests/03_OOP_Understanding.Tests/03_OOP_Understanding.Tests.csproj
```

## Documentation
- docs/00-Setup — IDE setup guides
- docs/01-DotNet-Basics — .NET CLI and runtime basics
- docs/02-Language-Basics — C# language basics
- docs/03-OOP-Fundamentals — OOP concepts overview

Open the docs alongside the code samples for the best learning experience.

## Project Structure
```
CSharp-Course-Repo/
├─ src/
│  ├─ CSharpBasics/
│  └─ 03_OOP_Understanding/
├─ tests/
│  └─ 03_OOP_Understanding.Tests/
└─ docs/
```

## Contributing / Learning Tips
- Start with src/CSharpBasics to warm up, then move to src/03_OOP_Understanding.
- Look for exercises/TODOs inside topic files and implement them.
- Use dotnet test to validate your understanding.
- Prefer small, incremental changes and keep examples simple.

## License
This project is licensed under the MIT License. See LICENSE for details.