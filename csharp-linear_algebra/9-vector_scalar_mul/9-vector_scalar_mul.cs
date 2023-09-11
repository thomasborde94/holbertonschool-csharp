using System;

/// <summary>
/// Defines VectorMath class
/// </summary>
class VectorMath
{
    /// <summary>
    /// multiplies a vector and a scalar
    /// </summary>
    /// <param name="vector">vector to multiply</param>
    /// <param name="scalar">scalar to multiply</param>
    /// <returns>vector multiplied by the scalar</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length > 3 || vector.Length < 2)
        {
            double[] error = new double[] {-1};
            return error;
        }

        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = scalar * vector[i];
        }
        return result;
    }
}
