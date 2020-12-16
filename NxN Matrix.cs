using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int matrix = PrintMatrix(digit);


        }

        static int PrintMatrix(int num)
        {
            for (int j = 0; j < num; j++)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            return num;
        }
    }
    }

