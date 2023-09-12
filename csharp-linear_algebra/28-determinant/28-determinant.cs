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
    /// Finds det of a 3X3 matrix
    /// </summary>
    /// <param name="matrix">matrix to find det of</param>
    /// <returns>determinant of the matrix</returns>
    public static double Determinant3D(double[,] matrix)
    {
        double[,] matrix1 = new double[2,2]
        {
            {matrix[1,1], matrix[1,2]},
            {matrix[2,1], matrix[2,2]}
        };
        double firstRow = matrix[0,0] * (Determinant2D(matrix1));

        double[,] matrix2 = new double[2,2]
        {
            {matrix[1,0], matrix[1,2]},
            {matrix[2,0], matrix[2,2]}
        };
        double secondRow = matrix[0,1] * (Determinant2D(matrix2));

        double[,] matrix3 = new double[2,2]
        {
            {matrix[1,0], matrix[1,1]},
            {matrix[2,0], matrix[2,1]}
        };
        double thirdRow = matrix[0,2] * (Determinant2D(matrix3));

        double det = firstRow - secondRow + thirdRow;
        return det;
    }

    /// <summary>
    /// Finds the determinant of a matrix
    /// </summary>
    /// <param name="matrix">matrix we want to find the determinant of</param>
    /// <returns>determinant of matrix</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.Length != 4 && matrix.Length != 9)
            return -1;

        if (matrix.Length == 4)
            return Math.Round(Determinant2D(matrix), 2);

        if (matrix.Length == 9)
            return Math.Round(Determinant3D(matrix), 2);
        
        return -1;
    }
}
