using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separate = { ',', ' ' };
            string[] listOfPeople = Console.ReadLine().Split(separate, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionaryOfNames = new Dictionary<string, int>();

            foreach (var name in listOfPeople)
            {
                dictionaryOfNames.Add(name, 0);

            }
            string namePattern = @"([\W\d])";
            string numberPattern = @"([\WA-Za-z])";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");

                int sum = 0;

                foreach (var digit in distance)
                {
                    int number = int.Parse(digit.ToString());
                    sum += number;
                }
                if (dictionaryOfNames.ContainsKey(name))
                {
                    dictionaryOfNames[name] += sum;

                }
                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var item in dictionaryOfNames.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{text} place: {item.Key}");
                if (count == 4)
                {
                    break;
                }
            }


        }
    }
}
