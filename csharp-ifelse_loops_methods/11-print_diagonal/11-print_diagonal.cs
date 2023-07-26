using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.WriteLine();
        else
        {
            for (int i = 1; i <= length; i++)
            {
                for (int spaces = 0; spaces <= i - 1; spaces++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
    }
}

