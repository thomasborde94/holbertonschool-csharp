using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Defines the Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object
    /// </summary>
    /// <param name="myObj">Object to print properties of</param>
    public static void Print(object myObj)
    {
        Type objectType = myObj.GetType();

        Console.WriteLine(objectType.Name + " Properties:");
        foreach (PropertyInfo property in objectType.GetProperties())
            Console.WriteLine(property.Name);

        Console.WriteLine(objectType.Name + " Methods:");
        foreach(MethodInfo method in objectType.GetMethods())
            Console.WriteLine(method.Name);
    }
}