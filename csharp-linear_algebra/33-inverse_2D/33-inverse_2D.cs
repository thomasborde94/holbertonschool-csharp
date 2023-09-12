using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Finds det of a 2X2 matrix
    /// </summary>
    /// <param name="matrix">matrix to find det of</param>
    /// <returns>determinant of the matrix</returns>
    public static double Determinant2D(double[,] matrix)
    {
        double det = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];
        return det;
    }
    /// <summary>
    /// finds the inverse of a 2D Matrix
    /// </summary>
    /// <param name="matrix">matrix to find the inverse of</param>
    /// <returns>inverse of matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] error = {{-1}};
        if (matrix.Length != 4 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return error;
        
        double det = Determinant2D(matrix);
        if (det == 0)
            return error;

        double[,] inversedMatrix = new double[2,2]
        {
            {Math.Round(1 / det * matrix[1,1], 2), Math.Round(1 / det * -matrix[0,1], 2)},
            {Math.Round(1 / det * -matrix[1,0], 2), Math.Round(1 / det * matrix[0,0], 2)}
        };
        
        return inversedMatrix;
    }
}