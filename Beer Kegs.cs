using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = 0;

            string biggestKeg = string.Empty;
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string currentKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heights = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * heights;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = currentKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
