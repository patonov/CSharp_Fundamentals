using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFirst = int.Parse(Console.ReadLine());
            int numberSecond = int.Parse(Console.ReadLine());
            int numberThird = int.Parse(Console.ReadLine());
            int numberFourth = int.Parse(Console.ReadLine());

            int sum = (numberFirst + numberSecond) / numberThird * numberFourth;
            Console.WriteLine(sum);
        }
    }
}
