using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = { ' ' };
            var input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            double results = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                char firstLetter = current[0];
                char secondLetter = current[current.Length - 1];
                double number = double.Parse(current.Substring(1, current.Length - 2));

                int firstLetterIndex = alphabet.IndexOf(char.ToUpper(firstLetter));
                int secondLetterIndex = alphabet.IndexOf(char.ToUpper(secondLetter));


                if ((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    number = number / (firstLetterIndex + 1);
                }
                else
                {
                    number = number * (firstLetterIndex + 1);
                }

                if ((int)secondLetter >= 65 && (int)secondLetter <= 90)
                {
                    number = number - (secondLetterIndex + 1);
                }
                else
                {
                    number = number + (secondLetterIndex + 1);
                }
                results += number;
            }
            Console.WriteLine("{0:F2}", results);




        }
    }
}
