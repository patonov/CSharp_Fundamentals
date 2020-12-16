using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            int result = PrintVowels(word);

            Console.WriteLine(result);
        }

        static int PrintVowels(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                if (currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if (currentChar == 'u')
                {
                    counter++;
                }
                else if (currentChar == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    }

