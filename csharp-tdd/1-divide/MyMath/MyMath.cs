using System;

namespace MyMath
{
    /// <summary>
    /// Defines the class Matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a Matrix
        /// </summary>
        /// <param name="matrix">Matrix to divide</param>
        /// <param name="num">Number the matrix is divided by</param>
        /// <returns>
        /// New matrix conaining divided elements
        /// If num is 0, return null. If matrix is null, return null.
        /// </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;
            
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];
            
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    try
                    {
                        result[x, y] = matrix[x, y] / num;
                    }

                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }
            return result;
        }
    }
}
