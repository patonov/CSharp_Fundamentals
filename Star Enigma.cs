using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfInputs = int.Parse(Console.ReadLine());
            string decrypted = string.Empty;

            List<string> planetsAttacked = new List<string>();
            List<string> planetsDestroyed = new List<string>();

            int planetsAttackedCount = 0;
            int planetsDestroyedCount = 0;

            for (int i = 0; i < numbersOfInputs; i++)
            {
                int key = 0;
                string input = Console.ReadLine();

                Regex keyReg = new Regex(@"[starSTAR]");

                MatchCollection matches = keyReg.Matches(input);

                key = matches.Count;

                StringBuilder build = new StringBuilder();
                char currentLetter = ' ';

                foreach (char letter in input)
                {
                    currentLetter = (char)(letter - key);
                    build.Append(currentLetter);
                }

                decrypted = build.ToString();

                Regex inputPattern = new Regex(@"\@([a-zA-Z]+)[^@\-!:>]*\:([0-9]+)[^@\-!:>]*\!(A|D)\![^@\-!:>]*\-\>[0-9]+");

                if (inputPattern.Match(decrypted).Success)
                {
                    string planet = inputPattern.Match(decrypted).Groups[1].Value;
                    string attack = inputPattern.Match(decrypted).Groups[3].Value;

                    if (attack.Equals("A"))
                    {
                        planetsAttacked.Add(planet);
                        planetsAttackedCount++;
                    }
                    else if (attack.Equals("D"))
                    {
                        planetsDestroyed.Add(planet);
                        planetsDestroyedCount++;
                    }
                }
            }
            Console.WriteLine("Attacked planets: {0}", planetsAttackedCount);

            foreach (var planet in planetsAttacked.OrderBy(x => x))
            {
                Console.WriteLine("-> {0}", planet);
            }

            Console.WriteLine("Destroyed planets: {0}", planetsDestroyedCount);

            foreach (var planet in planetsDestroyed.OrderBy(x => x))
            {
                Console.WriteLine("-> {0}", planet);
            }
        }
    }
}
