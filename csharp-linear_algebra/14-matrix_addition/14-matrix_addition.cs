using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two matrices
    /// </summary>
    /// <param name="matrix1">first matrix</param>
    /// <param name="matrix2">second matrix</param>
    /// <returns>addition of the two matrices</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] error = {{-1, -1}, {-1, -1}};
        // If matrices are not the same size
        if (matrix1.Length != matrix2.Length)
            return error;
        if (matrix1.Length != 4 && matrix1.Length != 9)
            return error;

        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
        return result;
    }
}
