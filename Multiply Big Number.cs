using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var bilder = new StringBuilder();
            string input = Console.ReadLine();
            int simpleDigit = int.Parse(Console.ReadLine());
            int rest = 0;

            foreach (char cipher in input.Reverse())
            {
                int digit = int.Parse(cipher.ToString());
                int result = digit * simpleDigit + rest;

                int restDigit = result % 10;
                rest = result / 10;

                bilder.Insert(0, restDigit);
            }

            if (rest > 0)
            {
                bilder.Insert(0, rest);
            }

            Console.WriteLine(bilder.ToString());


        }
    }
}
