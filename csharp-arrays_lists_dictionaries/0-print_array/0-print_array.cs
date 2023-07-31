using System;
using System.Collections.Generic;



class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] newArray = new int[size];
        if (size == 0)
        {
            Console.WriteLine();
            return newArray;
        }
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
            if (i != size - 1)
                Console.Write(i + " ");
            else
                Console.WriteLine(i);
        }
        return newArray;
    }
}

