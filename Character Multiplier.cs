using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { " " };
            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string firstArr = input[0];
            string secondArr = input[1];

            string forOperation = string.Empty;
            string notForOperation = string.Empty;

            int sum = 0;

            if (firstArr.Length > secondArr.Length)
            {
                forOperation = secondArr;
                notForOperation = firstArr;
            }
            else
            {
                forOperation = firstArr;
                notForOperation = secondArr;
            }


            for (int i = 0; i < forOperation.Length; i++)
            {
                char a = forOperation[i];
                char b = notForOperation[i];

                int currentSum = (int)a * (int)b;

                sum += currentSum;
            }
            string sub = notForOperation.Substring(forOperation.Length, notForOperation.Length - forOperation.Length);

            for (int i = 0; i < sub.Length; i++)
            {
                char currentChar = sub[i];
                sum += (int)currentChar;
            }

            Console.WriteLine(sum);


        }
    }
}
