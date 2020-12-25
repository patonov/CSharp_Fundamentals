using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> targets = new Dictionary<string, List<int>>();
            string targetTowns = Console.ReadLine();

            while (targetTowns != "Sail")
            {
                string[] targetArr = targetTowns.Split("||");
                string townTargeted = targetArr[0];
                int population = int.Parse(targetArr[1]);
                int gold = int.Parse(targetArr[2]);
                if (!targets.ContainsKey(townTargeted))
                {
                    targets.Add(townTargeted, new List<int>());
                    targets[townTargeted].Add(population);
                    targets[townTargeted].Add(gold);
                }
                else
                {
                    targets[townTargeted][0] += population;
                    targets[townTargeted][1] += gold;
                }
                targetTowns = Console.ReadLine();
            }
            string events = Console.ReadLine();

            while (events != "End")
            {
                string[] eventsArr = events.Split("=>");

                string eventGiven = eventsArr[0];

                if (eventGiven == "Plunder")
                {
                    string town = eventsArr[1];
                    int people = int.Parse(eventsArr[2]);
                    int gold = int.Parse(eventsArr[3]);
                    if (people < targets[town][0] && gold < targets[town][1])
                    {
                        targets[town][0] -= people;
                        targets[town][1] -= gold;
                    }

                    Console.WriteLine("{0} plundered! {1} gold stolen, {2} citizens killed.", town, gold, people);

                    if (targets[town][1] <= 0 || targets[town][0] <= 0)
                    {
                        targets.Remove(town);
                        Console.WriteLine("{0} has been wiped off the map!", town);
                    }
                }
                else if (eventGiven == "Prosper")
                {
                    string town = eventsArr[1];
                    int gold = int.Parse(eventsArr[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        targets[town][1] += gold;
                        int restGold = targets[town][1];

                        Console.WriteLine("{0} gold added to the city treasury. {1} now has {2} gold.", gold, town, restGold);
                    }
                }
                events = Console.ReadLine();
            }

            int targetsCount = targets.Count;

            if (targetsCount > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {targetsCount} wealthy settlements to go to:");

                foreach (var target in targets.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine("{0} -> Population: {1} citizens, Gold: {2} kg", target.Key, target.Value[0], target.Value[1]);
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
