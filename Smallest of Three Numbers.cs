using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            PrintSmallestNumber(number, numberOne, numberTwo);

        }

        static int PrintSmallestNumber(int a, int b, int c)
        {
            int smallestNumber = 0;

            if (a <= b && a <= c)
            {
                smallestNumber = a;
            }
            else if (b <= a && b <= c)
            {
                smallestNumber = b;
            }
            else
            {
                smallestNumber = c;
            }
            Console.WriteLine(smallestNumber);
            return smallestNumber;

        }
    }
    }

