using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int alphabet = 0; alphabet <= 98; alphabet++)
            {
                Console.WriteLine("{0} = 0x{1}" , alphabet, alphabet.ToString("x"));
            }
        }
    }
}
