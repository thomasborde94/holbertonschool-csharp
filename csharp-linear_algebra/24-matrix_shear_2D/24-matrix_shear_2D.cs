using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the X-shear of a point
    /// </summary>
    /// <param name="xValue">original x value</param>
    /// <param name="yValue">original y value</param>
    /// <param name="factor">shear factor</param>
    /// <returns>new coordinates of the point</returns>
    public static double[] ShearX(double xValue, double yValue, double factor)
    {
        double xResult = xValue + yValue * factor;
        return new double[] { xResult, yValue};
    }

    /// <summary>
    /// Calculates the Y-shear of a point
    /// </summary>
    /// <param name="xValue">original x value</param>
    /// <param name="yValue">original y value</param>
    /// <param name="factor">shear factor</param>
    /// <returns>new coordinates of the point</returns>
    public static double[] ShearY(double xValue, double yValue, double factor)
{
    double yResult = yValue + factor * xValue;
    return new double[] { xValue, yResult };
}


    /// <summary>
    /// Shears a square 2DMatrix
    /// </summary>
    /// <param name="matrix">matrix to shear</param>
    /// <param name="direction">direction X or Y</param>
    /// <param name="factor">Factor</param>
    /// <returns>a new Matrix</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] error = {{-1}};
        if (direction != 'x' && direction != 'y')
            return error;
        if (matrix.Length != 4 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return error;

        double[,] result = new double[2, 2];

        if (direction == 'x')
            {
                double[] pointA = ShearX(matrix[0, 0], matrix[0, 1], factor);
                double[] pointB = ShearX(matrix[1, 0], matrix[1, 1], factor);
                result[0, 0] = pointA[0];
                result[0, 1] = pointA[1];
                result[1, 0] = pointB[0];
                result[1, 1] = pointB[1];
            }

        if (direction == 'y')
            {
                double[] pointA = ShearY(matrix[0, 0], matrix[0, 1], factor);
                double[] pointB = ShearY(matrix[1, 0], matrix[1, 1], factor);
                result[0, 0] = pointA[0];
                result[0, 1] = pointA[1];
                result[1, 0] = pointB[0];
                result[1, 1] = pointB[1];
            }
        return result;
    }
}