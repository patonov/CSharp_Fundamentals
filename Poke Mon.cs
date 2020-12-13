using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustionFactor = int.Parse(Console.ReadLine());

            double tempPower = power * 0.5;
            int pokeCount = 0;

            while (power >= distance)
            {
                pokeCount++;
                power -= distance;

                if (power == tempPower && exaustionFactor != 0)
                {
                    power /= exaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokeCount);
        }
    }
}
