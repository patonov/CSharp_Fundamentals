using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string delimiter = Console.ReadLine();



            Console.Write("{0}", nameOne);
            Console.Write("{0}", delimiter);
            Console.Write("{0}", nameTwo);

        }
    }
}
