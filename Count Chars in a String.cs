using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!occurences.ContainsKey(letter))
                    {
                        occurences.Add(letter, 0);
                    }
                    occurences[letter]++;
                }
            }

            foreach (var c in occurences)
            {
                char currentChar = c.Key;
                int currentValue = c.Value;

                Console.WriteLine("{0} -> {1}", currentChar, currentValue);
            }

        }
    }
}
