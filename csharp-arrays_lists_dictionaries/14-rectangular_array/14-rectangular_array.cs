using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int[,] newArray = new int[5,5];
        newArray[2,2] = 1;
        int rows = newArray.GetLength(0);
        int columns = newArray.GetLength(1);
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                if (y == columns - 1)
                    Console.WriteLine(newArray[x,y]);
                else
                {
                    Console.Write(newArray[x,y] + " ");
                }
            }
        }
    }
}

