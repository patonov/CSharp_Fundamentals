using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int digit = int.Parse(number);
            int initialDigit = digit;
            int sumOne = 0;
            int sumOfFacts = 0;

            for (int i = 1; i <= number.Length; i++)
            {
                if (digit % 10 != 0)
                {
                    sumOne = digit % 10;


                    int fact = sumOne;
                    for (i = sumOne - 1; i >= 1; i--)
                    {
                        fact = fact * i;
                    }
                    sumOfFacts = sumOfFacts + fact;

                    digit = digit - sumOne;
                    digit = digit / 10;

                }
            }
            if (sumOfFacts == initialDigit)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
