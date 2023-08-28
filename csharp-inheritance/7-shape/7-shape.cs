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

/// <summary>
/// Defines Rectangle Class
/// </summary>
class Rectangle : Shape
{
    /// <summary>witdh of Rectangle</summary>
    private int width;
    /// <summary>height of Rectangle</summary>
    private int height;

    /// <summary>Gets or sets the width</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>Gets or sets the height</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    /// <summary>
    /// Defines area of Rectangle
    /// </summary>
    /// <returns>Area of Rectangle</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Override ToString method
    /// </summary>
    /// <returns>new ToString</returns>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", this.width, this.height);
    }
}