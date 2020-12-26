using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern = @"(@\#+)[A-Z][a-z]+[A-Z a-z 0-9]+[A-Z](@\#+)";


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, barcodePattern);
                if (match.Success)
                {
                    string compare = match.Value;
                    string temporary = string.Empty;
                    for (int j = 0; j < compare.Length; j++)
                    {
                        if (char.IsDigit(compare[j]))
                        {
                            temporary += compare[j];
                        }
                    }
                    if (temporary == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine("Product group: {0}", temporary);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
