using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[4];
        jaggedArray[1] = new int[7];
        jaggedArray[2] = new int[2];

        for (int x = 0; x < jaggedArray.Length; x++)
        {
            for (int y = 0; y < jaggedArray[x].Length; y++)
            {
                if (y == jaggedArray[x].Length - 1)
                {
                    Console.WriteLine(y);
                }
                else
                    Console.Write(y + " ");
            }
        }
    }
}

