using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";

            Regex rs = new Regex(pattern);

            MatchCollection matches = rs.Matches(input);

            string travelLenght = string.Empty;
            int travelPoints = 0;


            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    travelLenght += match.Groups["location"].Value;
                }
                travelPoints = travelLenght.Length;
            }


            Console.Write("Destinations: ");

            int counter = 0;
            foreach (Match match in matches)
            {
                counter++;
                if (counter < matches.Count)
                {
                    Console.Write(match.Groups["location"] + ", ");
                }
                else
                {
                    Console.Write(match.Groups["location"]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Travel Points: {0}", travelPoints);

        }
    }
}
