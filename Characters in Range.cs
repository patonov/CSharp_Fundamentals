using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintInBetween(firstChar, secondChar);

        }


        public static void PrintInBetween(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                char first = firstChar;
                firstChar = secondChar;
                secondChar = first;
            }
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
