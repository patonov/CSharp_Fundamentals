using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char cha in input)
            {
                char currentChar = (char)(cha + 3);
                Console.Write(currentChar);

            }
        }
    }
}
