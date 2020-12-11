using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());


            decimal dollars = pounds * 1.31M;


            Console.WriteLine("{0:F3}", dollars);
        }
    }
}
