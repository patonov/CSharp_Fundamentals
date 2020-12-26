using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeros = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroCollection = new Dictionary<string, List<int>>();
            int maxHP = 100;
            int maxMP = 200;

            for (int i = 0; i < numberOfHeros; i++)
            {
                string[] heroInfo = Console.ReadLine().Split();
                string heroName = heroInfo[0];
                int HP = int.Parse(heroInfo[1]);
                int MP = int.Parse(heroInfo[2]);
                heroCollection.Add(heroName, new List<int>());
                heroCollection[heroName].Add(HP);
                heroCollection[heroName].Add(MP);
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                char[] separator = { ' ', '-', ' ' };
                string[] commArr = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string heroName = commArr[1];

                if (commArr[0] == "CastSpell")
                {
                    int mpNeeded = int.Parse(commArr[2]);


                    if (mpNeeded <= heroCollection[heroName][1])
                    {
                        heroCollection[heroName][1] -= mpNeeded;
                        Console.WriteLine("{0} has successfully cast {1} and now has {2} MP!", commArr[1], commArr[3], heroCollection[heroName][1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} does not have enough MP to cast {1}!", heroName, commArr[3]);
                    }
                }
                else if (commArr[0] == "TakeDamage")
                {
                    int demage = int.Parse(commArr[2]);
                    heroCollection[heroName][0] -= demage;

                    if (heroCollection[heroName][0] > 0)
                    {
                        Console.WriteLine("{0} was hit for {1} HP by {2} and now has {3} HP left!", heroName, demage, commArr[3], heroCollection[heroName][0]);
                    }
                    else
                    {
                        heroCollection.Remove(heroName);
                        Console.WriteLine("{0} has been killed by {1}!", heroName, commArr[3]);
                    }

                }
                else if (commArr[0] == "Recharge")
                {
                    int amount = int.Parse(commArr[2]);
                    int oldMP = heroCollection[heroName][1];
                    heroCollection[heroName][1] += amount;

                    if (heroCollection[heroName][1] > maxMP)
                    {
                        heroCollection[heroName][1] = maxMP;
                        int difference = maxMP - oldMP;
                        Console.WriteLine("{0} recharged for {1} MP!", heroName, difference);
                    }
                    else
                    {
                        Console.WriteLine("{0} recharged for {1} MP!", heroName, amount);
                    }

                }
                else if (commArr[0] == "Heal")
                {
                    int amountForHeal = int.Parse(commArr[2]);
                    int oldHP = heroCollection[heroName][0];
                    heroCollection[heroName][0] += amountForHeal;

                    if (heroCollection[heroName][0] > maxHP)
                    {
                        heroCollection[heroName][0] = maxHP;
                        int difference = maxHP - oldHP;
                        Console.WriteLine("{0} healed for {1} HP!", heroName, difference);
                    }
                    else
                    {
                        Console.WriteLine("{0} healed for {1} HP!", heroName, amountForHeal);
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var hero in heroCollection.OrderByDescending(x => x.Value[0]))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine("  HP: {0}", hero.Value[0]);
                Console.WriteLine("  MP: {0}", hero.Value[1]);
            }
        }
    }
}
