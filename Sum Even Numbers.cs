using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int digit = numbers[i];

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
