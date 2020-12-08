using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nStart = int.Parse(Console.ReadLine());
            int sum = 0;

            if (nStart > 10)
            {
                sum = n * nStart;
                Console.WriteLine("{0} X {1} = {2}", n, nStart, sum);
            }

            for (int i = nStart; i <= 10; i++)
            {
                sum = n * i;
                Console.WriteLine("{0} X {1} = {2}", n, i, sum);
            }
        }
    }
}
