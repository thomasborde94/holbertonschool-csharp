# Test Driven Development
## Setup
* Create a solution file using `dotnet new sln` inside task directory.
* Create a new directory for your task solution based on the namespace given (ex: MyMath). This directory will hold your new standard class library.
* Inside that directory, run `dotnet new classlib`. Rename the resulting .cs file after the namespace (ex: MyMath.cs).
* Enable XML documentation by adding <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile> to MyMath.csproj.
* Change directory back to the root directory of the task (ex: 0-add) and run `dotnet sln add <classlibrary/classlibrary.csproj>` (ex. `dotnet sln add MyMath/MyMath.csproj`).
* Create a new directory for your tests based on the namespace given plus .Tests (ex: MyMath.Tests). This directory will hold your test library.
* Inside that directory, run `dotnet new nunit`. Rename the resulting .cs file after the namespace of classes you are testing plus .Tests (ex: MyMath.Tests.cs).
* To add your class library as a dependency to the project, run `dotnet add reference <../classlibrary/classlibrary.csproj>` (ex: `dotnet add reference ../MyMath/MyMath.csproj`).
* In the task’s root directory, run `dotnet sln add <testlibrary/testlibrary.csproj>` (ex: `dotnet sln add MyMath.Tests/MyMath.Tests.csproj`).
* If you’d like to run your class library method in a console application, create a new directory and run dotnet new console inside it. Run `dotnet add reference <../classlibrary/classlibrary.csproj>` and you can then call your class library methods inside the console application.<br>
* Use `dotnet test` to launch testing.<br>
For more detail, read the [Unit Testing C# with NUnit and .NET Core](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit) tutorial.<br>
[NUnit Cheat sheet](https://www.automatetheplanet.com/nunit-cheat-sheet/).