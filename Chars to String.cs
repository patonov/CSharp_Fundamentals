using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char nOne = char.Parse(Console.ReadLine());
            char nTwo = char.Parse(Console.ReadLine());
            char nThree = char.Parse(Console.ReadLine());


            Console.Write("{0}{1}{2}", nOne, nTwo, nThree);
        }
    }
}
