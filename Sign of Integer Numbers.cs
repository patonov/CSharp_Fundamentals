using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            PrintSignNumber(number);


        }

        static void PrintSignNumber(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }

        }
    }
    }

