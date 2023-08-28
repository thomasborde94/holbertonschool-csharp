using System;
using System.Collections.Generic;

/// <summary>
/// Defines the Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Tells if an object is of type int
    /// </summary>
    /// <param name="obj">object to analyse</param>
    /// <returns>True if type int, else false</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}