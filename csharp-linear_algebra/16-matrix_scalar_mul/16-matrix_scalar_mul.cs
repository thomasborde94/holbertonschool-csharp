using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a scalar and a matrix
    /// </summary>
    /// <param name="matrix">matrix to multiply</param>
    /// <param name="scalar">scalar to multiply</param>
    /// <returns>result of matrix * scalar</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] error = {{-1}};
        if (matrix.Length != 4 && matrix.Length != 9)
            return error;

        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                result[i, j] = matrix[i, j] * scalar;
        }
        return result;
    }
}