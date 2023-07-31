using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> list = new List<int>();
        if (size == 0)
        {
            Console.WriteLine();
            return list;
        }
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            if (i != size - 1)
                Console.Write(list[i] + " ");
            else
                Console.WriteLine(list[i]);
        }
        return list;
    }
}