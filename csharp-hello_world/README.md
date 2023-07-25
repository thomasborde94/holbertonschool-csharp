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

### Task 6
You can concatenate variables in a Console.WriteLine statement using a '+', for example: <br>
`Console.WriteLine(str + str + 8);` will print str 2 times followed by 8 and a newline.