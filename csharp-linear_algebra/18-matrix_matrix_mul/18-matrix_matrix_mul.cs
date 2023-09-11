using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices
    /// </summary>
    /// <param name="matrix1">first matrix</param>
    /// <param name="matrix2">second matrix</param>
    /// <returns>Result of matrix1 * matrix2</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] error = {{-1}};
        if (matrix1.Length == 0 || matrix2.Length == 0)
            return error;
        int matrix1Column = matrix1.GetLength(1);
        int matrix2Row = matrix2.GetLength(0);
        if (matrix1Column != matrix2Row)
            return error;
        
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}
