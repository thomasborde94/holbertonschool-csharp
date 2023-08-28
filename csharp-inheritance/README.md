# C# - Inheritance
To verify if an object is of a specific type, use `obj.GetType()`. For example:
```
public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
```