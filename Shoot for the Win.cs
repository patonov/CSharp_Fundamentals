using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] goals = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int targets = 0;

            while (command != "End")
            {
                int shot = int.Parse(command);

                if (shot <= goals.Length - 1)
                {
                    targets++;
                    int currentValue = goals[shot];
                    goals[shot] = -1;

                    for (int i = 0; i < goals.Length; i++)
                    {

                        if (goals[i] == -1)
                        {
                            continue;
                        }
                        if (goals[i] <= currentValue)
                        {
                            goals[i] += currentValue;
                        }
                        else if (goals[i] > currentValue)
                        {
                            goals[i] -= currentValue;
                        }


                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Shot targets: {0} -> {1}", targets, string.Join(" ", goals));

        }
    }
}
