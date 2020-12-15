using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int bestCounter = 0;
            int bestIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string currentElement = array[i];
                int currentCounter = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentElement == array[j])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCounter > bestCounter)
                {
                    bestCounter = currentCounter;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write(array[bestIndex] + " ");
            }
        }
    }
}
