# C#, Hello World
### Task 0
To initialize a new C# console application project, use `dotnet new console`. <br>
Use the option -n to specify a directory for the output.

### Task 1
To build (compile) a project, use `dotnet build [options] [project-file]`.

### Task 2
To run a project, use `dotnet run`. It will build and run the project, you don't need to
explicitly use `dotnet build` then `dotnet run`.

### Task 3, 4
Use Console.WriteLine() to print anything, followed by a newline.

### Task 5
The ToString() method converts an object into its string representation.<br>
There are many format specifiers you can use, like `ToString("F2")` to write a decimal number with a precision of 2 digits.

### Task 6, 7, 8
You can concatenate variables in a Console.WriteLine statement using a '+', for example: <br>
`Console.WriteLine(str + str + 8);` will print str 2 times followed by 8 and a newline.

### Task 9
You can use string interpolation when using Console.WriteLine().<br>
It allows you to embed expressions, variables, or values directly within a string using curly braces and the dollar sign prefix.<br>
For example : `Console.WriteLine($"Hello, {name}!")`.<br>
You can also specify formats, for example :
```
double percent = .7553;
Console.WriteLine($"Percent: {percent:P2}");
Output: Percent: 75.53 %
```

### Task 10, 11
Use string.Substring(int start index, [length]) to extract a substring of a given string.