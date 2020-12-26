using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordCouples = new List<string>();
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(@|#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1");

            MatchCollection matchWords = pattern.Matches(input);
            int counter = 0;

            foreach (Match match in matchWords)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["first"].Value;
                    string secondWord = match.Groups["second"].Value;
                    char[] secondWordChar = secondWord.ToCharArray();
                    Array.Reverse(secondWordChar);
                    string secondReversed = new string(secondWordChar).ToString();

                    if (firstWord == secondReversed)
                    {
                        string mirorCouple = firstWord + " <=> " + secondWord;
                        wordCouples.Add(mirorCouple);
                    }
                    counter++;
                }
            }
            if (matchWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine("{0} word pairs found!", counter);
            }
            if (wordCouples.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", wordCouples));
            }


        }
    }
}
