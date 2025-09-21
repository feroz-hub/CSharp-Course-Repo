# JetBrains Rider Setup Guide (C# Course)

This guide helps you install and configure JetBrains Rider for C# development on Windows, macOS, or Linux.

## Why Rider?
- Cross-platform IDE with a consistent experience across Windows/macOS/Linux
- Excellent .NET support with fast navigation, refactoring, and built-in inspections
- First-class Unity, ASP.NET Core, and Azure integration

## Prerequisites
- .NET SDK (LTS recommended)
- Sufficient disk space (2–5 GB for Rider + SDKs; more for workloads)
- Internet connection for downloads
- Optional: Unity Editor if you plan to do game development

## Step 1: Install the .NET SDK
1. Go to https://dotnet.microsoft.com/download
2. Download and install the latest LTS .NET SDK for your OS/architecture.
3. Verify installation in a new terminal:
   - `dotnet --info` should print SDK and runtime information without errors.

## Step 2: Install JetBrains Rider
### Option A: JetBrains Toolbox (Recommended)
1. Download JetBrains Toolbox from https://www.jetbrains.com/toolbox-app/
2. Install and launch Toolbox.
3. From Toolbox, install Rider (select the latest stable version).
4. Toolbox keeps Rider up to date automatically.

### Option B: Direct Download
1. Download Rider directly: https://www.jetbrains.com/rider/download/
2. Install the package for your OS and follow prompts.

## Step 3: First Launch & Initial Configuration
1. Start Rider. Log in with a JetBrains account (required for trial or license).
2. Select a keymap:
   - Visual Studio (for familiarity) or IntelliJ (default). You can change later: File → Settings/Preferences → Keymap.
3. Theme and fonts:
   - Choose a theme (Dark/Light). Consider enabling font ligatures if you like.
4. Plugins:
   - Ensure “.NET Core” and “NuGet” are enabled (default).
   - Optional: Azure Toolkit, Docker, GitHub, Markdown, CSV, etc.
5. Set SDKs:
   - Rider detects .NET automatically via the `dotnet` CLI.
   - Verify under File → Settings/Preferences → Build, Execution, Deployment → .NET → .NET CLI executable path.

## Step 4: Clone or Open the Course Repository
- Welcome screen → Get from VCS → paste repository URL → Clone
- Or File → Open and select the repository folder
- Rider will auto-restore NuGet packages on open.

## Step 5: Create and Run a Sample Project
1. File → New → Solution → Console Application → C#
2. Choose target framework (latest LTS), name it `HelloWorld`.
3. Replace Program.cs with:
   ```csharp
   using System;
   class Program
   {
       static void Main()
       {
           Console.WriteLine("Hello, World from Rider!");
       }
   }
   ```
4. Press Shift+F10 (Run) or use the Run icon. Use Shift+F9 to debug.

## Step 6: Configure Code Style and Inspections
- File → Settings/Preferences → Editor → Code Style → C#
  - Namespace declarations: File-scoped
  - Using directives: Place System first, remove unused usings on save
- File → Settings/Preferences → Editor → Inspections
  - Fine-tune severity for suggestions/warnings as desired
- Add an .editorconfig at repo root to share rules across tools/IDEs (example in VisualStudioSetup.md).

## Step 7: NuGet and Package Management
- View → Tool Windows → NuGet
- Search, install, and update packages per project or solution
- Configure sources via the gear icon (can add internal feeds or GitHub Packages)

## Step 8: Testing and Coverage
- Create a test project (xUnit, NUnit, or MSTest) and add references
- View → Tool Windows → Unit Tests
- Run/Debug tests, group by outcome, explore duration
- Optional: Install JetBrains dotCover for coverage (via Toolbox or Rider Plugins)

## Step 9: Git Integration
- VCS → Enable Version Control Integration (if not auto-enabled)
- Commit window (Alt+0): stage, commit, push with linters and pre-commit checks
- Create branches, rebase, resolve conflicts with Rider’s merge tool
- Sign in to GitHub/GitLab/Azure DevOps to create PRs directly

## Unity Development (Optional)
- Install the Unity Editor from https://unity.com/download
- Ensure the Rider Editor package is installed in Unity (Window → Package Manager → search “Rider”)
- In Unity: Preferences → External Tools → External Script Editor → JetBrains Rider
- Rider’s Unity plugin will offer play mode tests, debugger attach, and code generation

## Docker and Web Development (Optional)
- Install Docker Desktop (Windows/macOS) or Docker Engine (Linux)
- Enable Docker plugin in Rider
- Create Dockerfiles, docker-compose, and run/debug containers directly from Rider

## Troubleshooting
- Rider can’t find .NET SDK:
  - Ensure `dotnet --info` works in a new terminal
  - Check Settings → .NET → .NET CLI path
  - On macOS with Apple Silicon, ensure you installed the ARM64 SDK
- Slow indexing or high CPU:
  - Exclude large directories: Settings → Directories → Mark as Excluded
  - Increase memory: Help → Change Memory Settings
- NuGet restore failures:
  - Check proxy/SSL settings; configure NuGet sources
  - Delete %UserProfile%/.nuget/packages (Windows) or ~/.nuget/packages and restore again
- Debugger won’t attach:
  - Ensure correct target framework
  - On Linux, install `lldb`/`gdb` as prompted by Rider

## Shortcuts (Visual Studio keymap)
- Navigate to type: Ctrl+T
- Go to declaration: F12
- Rename: F2
- Refactor this: Ctrl+Shift+R
- Run: Ctrl+F5, Debug: F5
- Search everywhere: Ctrl+T (twice for more options)

## References
- Rider downloads: https://www.jetbrains.com/rider/download/
- JetBrains Toolbox: https://www.jetbrains.com/toolbox-app/
- .NET SDK: https://dotnet.microsoft.com/download
- Rider docs: https://www.jetbrains.com/help/rider/