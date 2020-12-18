using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagones = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgument = command.Split();

                if (commandArgument[0] == "Add")
                {
                    wagones.Add(int.Parse(commandArgument[1]));
                }
                else
                {
                    int passangers = int.Parse(commandArgument[0]);

                    for (int i = 0; i < wagones.Count; i++)
                    {
                        int currentWagone = wagones[i];
                        bool isTherePlace = currentWagone + passangers <= maxCapacity;

                        if (isTherePlace)
                        {
                            wagones[i] += passangers;
                            break;
                        }
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagones));

        }
    }
}
