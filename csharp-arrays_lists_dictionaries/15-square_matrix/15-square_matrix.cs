using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] newMatrix = new int[myMatrix.GetLength(0),myMatrix.GetLength(1)];
        int rows = newMatrix.GetLength(0);
        int columns = newMatrix.GetLength(1);
        
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                newMatrix[x,y] = (int)Math.Pow(myMatrix[x,y], 2);
            }
        }
        return newMatrix;
    }
}