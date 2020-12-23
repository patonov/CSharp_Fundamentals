using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string names = Console.ReadLine();

            MatchCollection interesting = Regex.Matches(names, pattern);

            foreach (Match item in interesting)
            {
                Console.Write(item.Value + ' ');
            }
        }
    }
}
