using System;
using System.Collections.Generic;

/// <summary>
/// Defines Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Tells if an object is an instance of, or if the object is an instance
    /// of a class that inherited from Array
    /// </summary>
    /// <param name="obj">Object to analyse</param>
    /// <returns>True if from Array, else False</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}