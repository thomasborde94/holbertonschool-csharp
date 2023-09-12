using System;

/// <summary>
/// Defines MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Shears a square 2DMatrix
    /// </summary>
    /// <param name="matrix">matrix to shear</param>
    /// <param name="direction">direction X or Y</param>
    /// <param name="factor">Factor</param>
    /// <returns>a new Matrix</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] error = {{-1}};
        if (direction != 'x' && direction != 'y')
            return error;
        if (matrix.Length != 4 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return error;

        double[,] result = new double[2, 2];
        double[,] directionMatrix = new double[2, 2];
        double[,] xShear = new double[2, 2]
        {
            {1, factor},
            {0, 1}
        };
        double[,] yShear = new double[2, 2]
        {
            {1, 0},
            {factor, 1}
        };
        if (direction == 'x')
            directionMatrix = xShear;
        if (direction == 'y')
            directionMatrix = yShear;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < directionMatrix.GetLength(1); j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < directionMatrix.GetLength(1); k++)
                {
                    result[i, j] += Math.Round(directionMatrix[i, k] * matrix[k, j], 2);
                }
            }
        }
        return result;
    }
}