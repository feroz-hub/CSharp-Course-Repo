# Visual Studio Setup Guide (C# Course)

This guide walks you through installing and configuring Microsoft Visual Studio for C# development on Windows in 2025. Visual Studio for Mac has been retired; macOS users should use JetBrains Rider or Visual Studio Code with the C# Dev Kit.

## Who is this for?
- Students following this C# course on Windows
- Learners who want a full-featured IDE with designers, integrated debugging, testing, and Git tools

## Prerequisites
- Supported OS: Windows 10 version 1909 or later, or Windows 11
- Disk space: 20–50 GB free (depending on selected workloads)
- Internet connection (for installer and workloads)
- Administrator rights for installation

## Step 1: Install the .NET SDK
Visual Studio can install the .NET SDK for you, but installing it first ensures the `dotnet` CLI is available in your shell.

1. Go to https://dotnet.microsoft.com/download
2. Download the latest Long-Term Support (LTS) .NET SDK (x64) for Windows.
3. Run the installer and follow the prompts.
4. Verify installation by opening a new terminal (Windows Terminal/PowerShell) and running:
   - `dotnet --info`
   - You should see the installed SDK version and runtimes listed without errors.

## Step 2: Install Visual Studio (Community Edition)
1. Navigate to https://visualstudio.microsoft.com/downloads/
2. Download “Visual Studio Community” (free for individual use, classroom learning, and open-source projects).
3. Run the Visual Studio Installer.
4. In the Workloads tab, select at minimum:
   - .NET desktop development
   - ASP.NET and web development (recommended for web APIs)
   - Optional (select as needed):
     - .NET Multi-platform App UI development (MAUI) if you’ll build cross-platform apps
     - Game development with Unity if you’ll use Unity
     - Data storage and processing if you’ll use SQL tooling
5. In the “Individual components” tab (optional but recommended):
   - .NET SDKs (matching your LTS version)
   - NuGet Package Manager
   - Git for Windows
   - Windows 10/11 SDK (latest)
6. Click Install. Allow the installer to complete and reboot if prompted.

## Step 3: First Launch and Recommended Settings
1. Start Visual Studio and sign in with a Microsoft account (enables syncing settings and extensions).
2. Choose a Development Settings profile:
   - “Visual C#” or “General” are both fine.
   - Choose your preferred color theme (Dark recommended).
3. Enable automatic restore and code quality:
   - Tools → Options → NuGet Package Manager → General → “Allow NuGet to download missing packages” and “Automatic restore” checked.
   - Tools → Options → Text Editor → C# → Advanced → enable “Place ‘System’ directives first when sorting usings” and consider enabling “Use file-scoped namespaces.”
4. Nullable and analyzers:
   - For new projects, set Nullable to “enable.” In existing projects, you can set `<Nullable>enable</Nullable>` in the .csproj.
   - Consider enabling .NET analyzers in .csproj: `<EnableNETAnalyzers>true</EnableNETAnalyzers>`.

## Step 4: Verify Your Environment
1. Create a new project: File → New → Project → “Console App” (.NET)
2. Name it `HelloWorld` and choose the latest LTS framework.
3. Replace Program.cs with:
   ```csharp
   using System;
   class Program
   {
       static void Main()
       {
           Console.WriteLine("Hello, World from Visual Studio!");
       }
   }
   ```
4. Press F5 (Run with Debugging). You should see the message in a console window.

## Step 5: Git and GitHub Integration
- Visual Studio includes built-in Git tools.
- View → Git Changes to stage, commit, and push.
- To clone this course repo: Git → Clone Repository → paste the repository URL.
- Sign in to GitHub via Accounts → Add an account for seamless push/pull and PRs.

## Step 6: Useful Extensions (Optional)
- ReSharper (JetBrains) — powerful refactorings and navigation.
- GitHub Copilot — AI pair programming.
- Roslynator — additional analyzers and refactorings.

## Step 7: Code Style and .editorconfig
To keep the course code consistent, consider adding an .editorconfig at the repository root:
```
root = true

[*.cs]
dotnet_style_qualification_for_field = false:suggestion
csharp_style_var_for_built_in_types = true:suggestion
csharp_new_line_before_open_brace = all:true
csharp_style_namespace_declarations = file_scoped:suggestion

[*.{csproj,props,targets}]
indent_size = 2
```
Commit this file so teammates share the same conventions.

## Step 8: Unit Testing
- Install xUnit, NUnit, or MSTest via NuGet for your test projects.
- Test Explorer: Test → Test Explorer. Use “Run All Tests.”
- Debug tests using the green bug icon next to a test.

## Troubleshooting
- Installer fails or hangs:
  - Run the Visual Studio Installer as Administrator.
  - Clear the installer cache: %ProgramData%\Microsoft\VisualStudio\Packages
  - Use the Visual Studio Installer “Repair” option.
- Missing .NET SDK in terminal but works in Visual Studio:
  - Reopen terminal after installation.
  - Ensure “C:\Program Files\dotnet” is on PATH.
- Build errors about missing workloads:
  - Open Visual Studio Installer → Modify → ensure the required workload is selected.
- Visual Studio for Mac:
  - Visual Studio for Mac has been retired. Use JetBrains Rider or Visual Studio Code with C# Dev Kit on macOS.

## Uninstall or Modify
- Open “Visual Studio Installer” from Start Menu.
- Click More → Repair, or Modify to add/remove workloads, or Uninstall.

## References
- Visual Studio downloads: https://visualstudio.microsoft.com/downloads/
- .NET SDK downloads: https://dotnet.microsoft.com/download
- Workloads and components: https://learn.microsoft.com/visualstudio/install/workload-component-id-vs-enterprise
- .editorconfig for .NET: https://learn.microsoft.com/dotnet/fundamentals/code-analysis/configuration/editorconfig