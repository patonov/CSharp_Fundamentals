using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] arr = new int[n];


            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int amount = arr[i];
                Console.Write("{0} ", amount);
                sum += amount;
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
