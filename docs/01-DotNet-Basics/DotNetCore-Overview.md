# .NET Core (Modern .NET) Overview — Beginner Friendly

Note on naming: Since 2020, ".NET Core" evolved into ".NET" (versions 5, 6, 7, 8, …). People still say ".NET Core" casually, but the official name is just ".NET" now. This guide uses ".NET" to mean the modern, cross‑platform .NET.

---

## 1) What is .NET (Core)?

- A free, open‑source, cross‑platform developer platform for building apps.
- Runs on Windows, Linux, and macOS.
- Great for Web APIs and websites (ASP.NET Core), cloud services, console tools, background workers, desktop apps (WinForms/WPF on Windows), cross‑platform client apps (MAUI), and more.
- Uses the same language options you know: C#, F#, and VB (C# is most common).

How it’s different from the old ".NET Framework":
- .NET Framework was Windows‑only and is in maintenance for existing apps.
- Modern .NET is cross‑platform, faster, modular, and supports side‑by‑side versions.

---

## 2) Why developers choose modern .NET

- Cross‑platform: Build and run on Windows, Linux, macOS, and containers.
- Performance: Among the fastest web frameworks (TechEmpower benchmarks). JIT and GC optimizations.
- Developer experience: Simple SDK install, first‑class CLI, great IDEs (Rider, Visual Studio, VS Code).
- Unified: One BCL (Base Class Library), one toolchain across app types.
- Open source: Developed on GitHub with an active community.

---

## 3) Core concepts you should know

- SDK vs Runtime
  - Runtime: Just enough to run apps.
  - SDK: Includes runtime + compilers + tooling (dotnet CLI). Install the SDK to develop.
- Side‑by‑side installation
  - You can install multiple .NET versions on one machine. Each app can target its own version.
- Target Framework Moniker (TFM)
  - Example: `net8.0`, `net7.0`. Choose the TFM you build against in your project file.
- LTS vs STS releases
  - LTS (Long‑Term Support) versions are supported for 3 years (e.g., .NET 6, .NET 8). STS have shorter support.

---

## 4) What can I build?

- ASP.NET Core Web APIs and full websites (MVC/Razor Pages, Minimal APIs)
- Background services/Workers, console tools
- Real‑time apps with SignalR
- gRPC services
- Cloud‑native apps (Docker, Kubernetes)
- Desktop (Windows only: WinForms/WPF) and cross‑platform client (MAUI)

---

## 5) Project structure (typical)

For a console or web project you’ll commonly see:

- Program.cs — App entry point. Minimal hosting is common now.
- appsettings.json — Configuration (with environment overrides like appsettings.Development.json).
- .csproj — Project file (SDK style) where you set target framework, packages, etc.
- Controllers/Pages or Endpoints (for web)
- Models/DTOs — Data classes
- Services — Your business logic

Example minimal Program.cs for a Web API (Minimal API style):

```csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to DI container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/hello", () => new { Message = "Hello, .NET!" });

app.Run();
```

---

## 6) The dotnet CLI — essentials

- Create a project
  - Console: `dotnet new console -n HelloConsole`
  - Web API: `dotnet new webapi -n MyApi`
- Restore packages: `dotnet restore`
- Build: `dotnet build`
- Run: `dotnet run`
- Test: `dotnet test`
- Add a NuGet package: `dotnet add package Serilog.AspNetCore`
- Publish:
  - Framework‑dependent: `dotnet publish -c Release`
  - Self‑contained (Linux x64): `dotnet publish -c Release -r linux-x64 --self-contained true`

Tip: Run `dotnet --info` to see installed SDKs and runtimes.

---

## 7) Configuration, DI, and Logging (built‑in)

- Configuration: appsettings.json, environment variables, user secrets (dev), Azure Key Vault, etc.
- Dependency Injection (DI): Built into the framework — register services via `builder.Services.Add...`.
- Logging: Built‑in logging abstractions with providers (Console, Debug, Serilog, Seq, Application Insights).

Example registration:
```csharp
builder.Services.AddHttpClient();
builder.Services.AddScoped<IMyService, MyService>();
```

---

## 8) Data access with EF Core (quick view)

- EF Core is the modern ORM for .NET.
- Works with SQL Server, PostgreSQL, MySQL, SQLite, Cosmos DB, and more (via providers).
- Typical commands:
  - Add EF tools: `dotnet tool install --global dotnet-ef`
  - Add a migration: `dotnet ef migrations add InitialCreate`
  - Update database: `dotnet ef database update`

---

## 9) Hosting and middleware (ASP.NET Core)

- Unified hosting model with a middleware pipeline (ordered components that handle requests).
- Common middleware: HTTPS redirection, static files, routing, authentication/authorization, CORS, Swagger.
- Minimal APIs, MVC controllers, or Razor Pages can live in the same app.

---

## 10) Deployment options

- Framework‑Dependent Deployment (FDD)
  - Smaller output. Requires the target machine to have the matching .NET runtime installed.
- Self‑Contained Deployment (SCD)
  - Includes the runtime with your app. Larger output, but no runtime needed on the server.
- Single‑file publishing
  - Package app (and optionally runtime) into one executable: `-p:PublishSingleFile=true`
- Trimming/AOT (advanced)
  - Reduce size with trimming; Native AOT for very fast startup (some constraints apply).

Runtime Identifiers (RID) examples: `win-x64`, `linux-x64`, `osx-arm64`.

---

## 11) Versions and support

- Choose LTS for production stability (e.g., .NET 6, .NET 8).
- Keep SDKs updated, and plan upgrades as LTS windows end.

Check: https://dotnet.microsoft.com/platform/support/policy/dotnet 

---

## 12) Migrating from .NET Framework (high level)

- Target class libraries to `netstandard2.0` where possible for widest compatibility.
- Replace Windows‑only technologies with cross‑platform alternatives where needed.
- Use the .NET Upgrade Assistant tool to analyze and assist migration.
- Test thoroughly; some APIs and web frameworks changed (ASP.NET -> ASP.NET Core).

---

## 13) Quick start (5 minutes)

1) Install the .NET SDK: https://dotnet.microsoft.com/download
2) Create and run a console app:
```
dotnet new console -n FirstApp
cd FirstApp
 dotnet run
```
3) Create and run a Web API:
```
dotnet new webapi -n FirstApi
cd FirstApi
 dotnet run
```
4) Open in your IDE (Rider / VS / VS Code) and start coding!

---

## 14) FAQ

- Is .NET free for commercial use? Yes.
- Which OS is best for running .NET apps? All major OSes are supported; Linux is popular in servers/containers.
- Do I need Visual Studio? No. You can use Rider or VS Code with the C# extension, or just the CLI.
- What is ASP.NET Core? The web framework built on top of .NET for APIs, MVC, Razor Pages, SignalR, etc.

---

## 15) Glossary

- SDK: Software Development Kit (tooling + compilers + runtime).
- TFM: Target Framework Moniker (e.g., net8.0).
- FDD/SCD: Framework‑Dependent vs Self‑Contained Deployment.
- RID: Runtime Identifier (target OS/CPU, e.g., linux-x64).
- DI: Dependency Injection.
- EF Core: Entity Framework Core (ORM for data access).

---

## 16) Summary

- Modern .NET (formerly .NET Core) is a fast, cross‑platform, open‑source platform.
- One toolchain (dotnet CLI), built‑in DI/logging/config, and first‑class web framework (ASP.NET Core).
- Choose an LTS version, start with the CLI templates, and grow from console apps to cloud‑native services.
