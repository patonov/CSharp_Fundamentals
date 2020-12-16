using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopInteger(number);


        }

        static void PrintTopInteger(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                string currentNumber = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (var current in currentNumber)
                {
                    int parseNumber = (int)current;
                    if (parseNumber % 2 == 1)
                    {
                        isOddDigit = true;
                    }
                    sumOfDigits += parseNumber;
                }
                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

