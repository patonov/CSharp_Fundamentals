using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
                counter++;
                sum += i;

                if (counter == n)
                {
                    Console.WriteLine("Sum: {0}", sum);
                    break;
                }
            }
        }
    }
}
