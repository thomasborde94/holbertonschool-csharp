using System;

/// <summary>
/// Defines VectorMath class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Returns dot product of two vectors
    /// </summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">second vector</param>
    /// <returns>Dot products of the two vectors</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length > 3 || vector1.Length < 2 || vector2.Length > 3 || vector2.Length < 2 || vector1.Length != vector2.Length)
        {
            return -1;
        }

        double result = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i];
        }
        return result;
    }
}
