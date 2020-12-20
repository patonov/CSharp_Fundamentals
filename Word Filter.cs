using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }

        }
    }
}
