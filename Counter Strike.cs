using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string distance = Console.ReadLine();


            int winBattles = 0;

            while (distance != "End of battle")
            {
                int currentDistance = int.Parse(distance);

                if (initialEnergy >= currentDistance)
                {
                    winBattles++;
                    initialEnergy -= currentDistance;

                    if (winBattles % 3 == 0)
                    {
                        initialEnergy += winBattles;
                    }
                }
                else
                {
                    Console.WriteLine("Not enough energy! Game ends with {0} won battles and {1} energy", winBattles, initialEnergy);
                    break;
                }

                distance = Console.ReadLine();
            }

            if (distance == "End of battle")
            {
                Console.WriteLine("Won battles: {0}. Energy left: {1}", winBattles, initialEnergy);
            }

        }
    }
}
