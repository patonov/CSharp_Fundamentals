using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359 2 \d{3} \d{4}\b)|(\+ ?359-2-\d{3}-\d{4}\b)";
            string phones = Console.ReadLine();

            MatchCollection phonesMatched = Regex.Matches(phones, pattern);

            var matchPhoneArr = phonesMatched.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchPhoneArr));
        }
    }
}
