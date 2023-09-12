using System;

/// <summary>
/// Defines VectorMath class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Finds the cross product of two vectors
    /// </summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">second vector</param>
    /// <returns>cross product</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] error = new double[1] {-1};
        if (vector1.Length != 3 || vector2.Length != 3)
            return error;
        double first = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        double second = vector1[0] * vector2[2] - vector1[2] * vector2[0];
        double third = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        double[] result = {first, second, third};
        return result;

    }
}
