using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();


            while (command != "End")
            {
                string[] commandArray = command.Split();

                if (commandArray[0] == "Shoot")
                {
                    int currentIndex = int.Parse(commandArray[1]);
                    int currentPower = int.Parse(commandArray[2]);
                    if (currentIndex < targets.Count)
                    {
                        targets[currentIndex] -= currentPower;
                        if (targets[currentIndex] == 0)
                        {
                            targets.Remove(0);
                        }
                    }

                }
                else if (commandArray[0] == "Add")
                {
                    int currentIndex = int.Parse(commandArray[1]);
                    int currentValue = int.Parse(commandArray[2]);
                    if (currentIndex < targets.Count)
                    {
                        targets.Insert(currentIndex, currentValue);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (commandArray[0] == "Strike")
                {
                    int currentIndex = int.Parse(commandArray[1]);
                    int currentRadius = int.Parse(commandArray[2]);
                    if (currentIndex < targets.Count && (currentIndex - currentRadius) >= 0 && (currentRadius + currentIndex) <= targets.Count - 1)
                    {
                        targets.RemoveAt(targets[currentIndex]);

                        for (int i = currentIndex; i <= currentRadius + 1; i++)
                        {
                            targets.RemoveAt(targets[i]);
                        }

                        for (int i = currentRadius - 1; i < currentIndex; i--)
                        {
                            targets.RemoveAt(targets[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));

        }
    }
}
