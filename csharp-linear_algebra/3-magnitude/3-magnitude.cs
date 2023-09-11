using System;

/// <summary>
/// Defines the VectorMath class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the length of a given vector
    /// </summary>
    /// <param name="vector">vector to calculate length of</param>
    /// <returns>Length of vector</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length > 3 || vector.Length < 2)
            return -1;
        double resultSqr = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            resultSqr += vector[i] * vector[i];
        }
        double result = Math.Sqrt(resultSqr);
        return Math.Round(result, 2);
    }
}
