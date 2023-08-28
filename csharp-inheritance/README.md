# C# - Inheritance
To verify if an object is of a specific type, use `obj.GetType()`. For example:
```
public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
```

To verify if an object is an instance of a specific Type, or if the  object is an instance of a class that inherited from a specific class, you can use `is`. For example:
```
public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
```