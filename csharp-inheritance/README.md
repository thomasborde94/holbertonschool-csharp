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

To verify if an object is an instance of a class that inherits from a specified class, use `IsSubclassOf()`. For example:
```
public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
```

## Override and New keywords
When working on derived class, you may want to override an existing method of the base class. You may use override or new keywords to do this.
* `override` Keyword:
    * When you use the override keyword, you're indicating that you are providing a new implementation for a method that's already defined in the base class.
    * The base class method must be marked as virtual, abstract, or override.
    * The method in the derived class must have the same signature as the method in the base class (name, parameters, and return type).
    * When calling the method on an instance of the derived class, the overridden method in the derived class will be called instead of the base class method.
* `new` Keyword:
    * When you use the new keyword, you're indicating that you're providing a new method with the same name as a method in the base class. This doesn't override the base class method; it simply hides it.
    * The base class method doesn't need to be marked as virtual, abstract, or override.
    * The method in the derived class doesn't need to have the same signature as the method in the base class.
    * When calling the method on an instance of the derived class, the method in the derived class will be called, regardless of the runtime type of the object.
    * It's used to create a new method in the derived class that has the same name as a method in the base class but behaves differently.