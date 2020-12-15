using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isBigger = true;

            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] >= currentElement)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write("{0} ", currentElement);
                }

                isBigger = true;
            }
        }
    }
}
