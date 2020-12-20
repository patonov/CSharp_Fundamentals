using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();
            int counter = 0;

            foreach (var item in input)
            {
                if (!numbers.ContainsKey(item))
                {
                    numbers.Add(item, 0);
                }
                else
                {
                    continue;
                }
            }
            foreach (var item in numbers.OrderByDescending(n => n.Key))
            {
                counter++;
                Console.Write(item.Key + " ");
                if (counter >= 3)
                {
                    break;
                }
            }

        }
    }
}
