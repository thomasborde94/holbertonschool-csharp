using System;

/// <summary>
/// Defines Shape Class
/// </summary>
class Shape
{
    /// <summary>
    /// Gets area if methods in implemented
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public virtual int Area()
    {
        throw new Exception("Area() is not implemented");
    }
}