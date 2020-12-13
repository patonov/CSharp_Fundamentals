using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChart = int.Parse(Console.ReadLine());
            int endChart = int.Parse(Console.ReadLine());

            for (int i = startChart; i <= endChart; i++)
            {
                Console.Write("{0} ", (char)i);
            }

        }
    }
}
