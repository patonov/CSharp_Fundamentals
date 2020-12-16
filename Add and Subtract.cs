using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int sum = SumOfFirstTwo(numOne, numTwo);
            int diff = DifferenceOfThird(numOne, numTwo, numThree);

            Console.WriteLine(diff);
        }

        static int SumOfFirstTwo(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        static int DifferenceOfThird(int numOne, int numTwo, int numThree)
        {
            int sum = numOne + numTwo;
            int difference = sum - numThree;
            return difference;
        }
    }
    }
}
