using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter >= 65 && letter <= 90)
            {
                Console.Write("upper-case");
            }
            else if (letter >= 97 && letter <= 122)
            {
                Console.Write("lower-case");
            }
        }
    }
}
