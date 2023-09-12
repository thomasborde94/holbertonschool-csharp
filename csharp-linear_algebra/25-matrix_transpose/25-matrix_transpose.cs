using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transposes a matrix (flips it over its main diagonal)
    /// </summary>
    /// <param name="matrix">matrix to transpose</param>
    /// <returns>Transposed matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return new double[0,0];
        
        double[,] transposedMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                transposedMatrix[i, j] = matrix[j, i];
            }
        }
        return transposedMatrix;
    }
}
