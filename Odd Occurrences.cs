using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] things = Console.ReadLine().Split();

            Dictionary<string, int> thingsDict = new Dictionary<string, int>();

            foreach (var thing in things)
            {
                string wordLowerCase = thing.ToLower();
                if (thingsDict.ContainsKey(wordLowerCase))
                {
                    thingsDict[wordLowerCase]++;
                }
                else
                {
                    thingsDict.Add(wordLowerCase, 1);
                }
            }

            foreach (var thing in thingsDict)
            {
                if (thing.Value % 2 != 0)
                {
                    Console.Write(thing.Key + " ");
                }
            }

        }
    }
}
