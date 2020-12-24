using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            int jumpPosition = 0;
            int newJumpPosition = 0;

            string command = Console.ReadLine();

            while (command != "Love!")
            {
                string[] comArr = command.Split().ToArray();
                jumpPosition = int.Parse(comArr[1]);
                newJumpPosition += jumpPosition;

                if (newJumpPosition > neighborhood.Length - 1)
                {
                    newJumpPosition = 0;
                }

                if (neighborhood[newJumpPosition] == 0)
                {
                    Console.WriteLine("Place {0} already had Valentine's day.", newJumpPosition);
                }
                else
                {

                    neighborhood[newJumpPosition] -= 2;

                    if (neighborhood[newJumpPosition] == 0)
                    {
                        Console.WriteLine("Place {0} has Valentine's day.", newJumpPosition);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Cupid's last position was {0}.", newJumpPosition);

            int houseCount = 0;

            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] == 0)
                {
                    houseCount++;
                }
            }

            if (houseCount == neighborhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int difference = neighborhood.Length - houseCount;
                Console.WriteLine("Cupid has failed {0} places.", difference);
            }
        }
    }
}
