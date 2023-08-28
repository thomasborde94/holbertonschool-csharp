using System;

/// <summary>
/// Defines the Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Tells if an object is an instance of a class that inherits from the specified class
    /// </summary>
    /// <param name="derivedType">Derived class</param>
    /// <param name="baseType">Base class</param>
    /// <returns>True if the object is of type subclass, else False</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}