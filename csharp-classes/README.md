# Classes and Namespaces
## XML Documentation
To enable XML documentation in your project, you must add this line to the PropertyGroup in your .csproj file:
```
<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>
```

Use `dotnet build --configuration Debug` to generate the xml documentation file in the Debug folder.<br>
By adding meaningful comments to your code and generating an XML documentation file, you create a self-documenting codebase. The documentation file provides context, usage details, and explanations for classes, methods, properties, and other code elements. This makes it easier for developers to understand how to use your code effectively.
## Namespaces
Namespaces are heavily used in C# programming in two ways. First, .NET uses namespaces to organize its many classes, as follows:
```
System.Console.WriteLine("Hello World!");
```
System is a namespace and Console is a class in that namespace. The using keyword can be used so that the complete name isn't required, as in the following example:
```
using System;
```
Second, declaring your own namespaces can help you control the scope of class and method names in larger programming projects. Use the namespace keyword to declare a namespace, as in the following example:
```
namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
                "SampleMethod inside SampleNamespace");
        }
    }
}
```
Beginning with C# 10, you can declare a namespace for all types defined in that file, as shown in the following example:
```
namespace SampleNamespace;

class AnotherSampleClass
{
    public void AnotherSampleMethod()
    {
        System.Console.WriteLine(
            "SampleMethod inside SampleNamespace");
    }
}
```

## Classes
### Constructors
Use constructors to define an instance's properties, with restrictions or not:
```
public Zombie(int value)
        {
            if (value >= 0)
                health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
```
### Properties
Allows to get or set a field's value:
```
public string Name
        {
            get { return name; }
            set { name = value;}
        }
```