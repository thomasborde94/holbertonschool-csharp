using System;

/// <summary>
/// Defines the VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// adds two vectors
    /// </summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">second vector</param>
    /// <returns>addition of the two vectors</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length > 3 || vector1.Length < 2 || vector2.Length > 3 || vector2.Length < 2 || vector1.Length != vector2.Length)
        {
            double[] error = new double[] {-1};
            return error;
        }

        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        return result;
    }
}
