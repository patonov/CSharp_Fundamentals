using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymsDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < input; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymsDict.ContainsKey(word))
                {
                    synonymsDict.Add(word, new List<string>());
                }

                synonymsDict[word].Add(synonym);
            }

            foreach (var item in synonymsDict)
            {
                Console.WriteLine("{0} - {1}", item.Key, string.Join(", ", item.Value));
            }
        }
    }
}
