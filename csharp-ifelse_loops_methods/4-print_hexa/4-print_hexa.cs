﻿using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 0; number <= 98; number++)
            {
                Console.WriteLine(number + " = " + "0x" + number.ToString("x"));
            }
        }
    }
}
