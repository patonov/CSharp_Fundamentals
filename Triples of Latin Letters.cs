using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstSybol = 0; firstSybol < n; firstSybol++)
            {
                for (int secondSybol = 0; secondSybol < n; secondSybol++)
                {
                    for (int thirdSybol = 0; thirdSybol < n; thirdSybol++)
                    {
                        char firstChar = (char)(97 + firstSybol);
                        char secondChar = (char)(97 + secondSybol);
                        char thirdChar = (char)(97 + thirdSybol);

                        Console.WriteLine("{0}{1}{2}", firstChar, secondChar, thirdChar);
                    }

                }

            }
        }
    }
}
