using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "";
            for (char letter = 'a'; letter <= 'z'; letter++)
                abc += letter;
            Console.Write(abc);
        }
    }
}
