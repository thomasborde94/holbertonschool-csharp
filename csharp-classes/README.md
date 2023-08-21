# Classes and Namespaces
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