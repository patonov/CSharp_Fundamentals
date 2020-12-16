using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string output = GetMiddleOfEvenString(input);
                Console.WriteLine(output);
            }
            else
            {
                string oddOutput = GettingMiddleOfOddString(input);
                Console.WriteLine(oddOutput);
            }




        }
        static string GetMiddleOfEvenString(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }

        static string GettingMiddleOfOddString(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }
    }
    }

