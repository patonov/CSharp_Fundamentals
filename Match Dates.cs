using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})\2(\d{4})\b";

            var inputDates = Console.ReadLine();

            MatchCollection matchedDates = Regex.Matches(inputDates, pattern);

            foreach (Match date in matchedDates)
            {
                var day = date.Groups[1].Value;
                var month = date.Groups[3].Value;
                var year = date.Groups[4].Value;
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", day, month, year);
            }

        }
    }
}
