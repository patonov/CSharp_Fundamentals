using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne = int.Parse(Console.ReadLine());
            int digitTwo = int.Parse(Console.ReadLine());

            double calculateFactorialFirstDigit = GetFactorial(digitOne);
            double calculateFactorialSecondDigit = GetFactorial(digitTwo);

            double result = calculateFactorialFirstDigit / calculateFactorialSecondDigit;

            Console.WriteLine("{0:F2}", result);
        }
        static double GetFactorial(double num)
        {
            double result = 1;
            while (num != 1)
            {
                result = result * num;
                num = num - 1;
            }
            return result;
        }
    }
    }

