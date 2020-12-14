using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();



            Console.Write(string.Join(" ", words.Reverse()));

        }
    }
}
