using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> numbersDict = new SortedDictionary<int, int>();


            foreach (var number in numbers)
            {
                if (numbersDict.ContainsKey(number))
                {
                    numbersDict[number]++;
                }
                else
                {
                    numbersDict.Add(number, 1);
                }
            }

            foreach (var number in numbersDict)
            {
                Console.WriteLine("{0} -> {1}", number.Key, number.Value);
            }

        }
    }
}
