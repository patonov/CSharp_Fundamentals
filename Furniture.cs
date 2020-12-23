using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Z a-z]+)<<(\d+\.?\d*)!(\d+)";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            double totalPrice = 0;

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);
                    Console.WriteLine(name);

                    totalPrice += quantity * price;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Total money spend: {0:F2}", totalPrice);


        }
    }
}
