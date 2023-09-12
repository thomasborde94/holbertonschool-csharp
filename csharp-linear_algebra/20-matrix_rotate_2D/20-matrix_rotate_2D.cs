using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a matrix by an angle in rads
    /// </summary>
    /// <param name="matrix">Matrix to rotate</param>
    /// <param name="angle">angle in radians</param>
    /// <returns>a new Matrix</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] error = {{-1}};
        if (matrix.Length != 4 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return error;

        double[,] result = new double[2, 2];
        double sum = 0.0;
        double[,] rotationMatrix = new double[2, 2]
            {
                {Math.Cos(angle), Math.Sin(angle)},
                {-Math.Sin(angle), Math.Cos(angle)}
            };

        for (int i = 0; i < rotationMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    result[i, j] += Math.Round(matrix[i, k] * rotationMatrix[k, j], 2);
                }
            }
        }

        return result;
    }
}