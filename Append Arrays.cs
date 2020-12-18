using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();

            items.Reverse();

            List<string> result = new List<string>();

            foreach (string item in items)
            {
                string[] numbers = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
