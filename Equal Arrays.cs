using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbersTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumOne = 0;
            int sumTwo = 0;
            int index = 0;
            int difference = 0;

            for (int i = 0; i < numbersOne.Length; i++)
            {
                int digitOne = numbersOne[i];
                sumOne += digitOne;
                int digitTwo = numbersTwo[i];
                sumTwo += digitTwo;

                if (digitTwo != digitOne)
                {
                    difference = digitTwo - digitOne;
                    index = i;
                    break;
                }
            }


            if (sumOne == sumTwo)
            {
                Console.WriteLine("Arrays are identical. Sum: {0}", sumOne);
            }
            else
            {
                Console.WriteLine("Arrays are not identical. Found difference at {0} index", index);
            }


        }
    }
}
