using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
            Console.WriteLine();
        else
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
}

