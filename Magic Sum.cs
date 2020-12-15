using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < array.Length; i++)
            {
                int firstNumber = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNumber = array[j];

                    if (firstNumber + secondNumber == number)
                    {
                        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
                        break;
                    }
                }

            }
        }
    }
}
