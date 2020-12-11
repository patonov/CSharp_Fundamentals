using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool isSpecialNumber = false;

            for (int i = 1; i <= number; i++)
            {
                digit = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digit, isSpecialNumber);
                sum = 0;
                i = digit;
            }
        }
    }
}
