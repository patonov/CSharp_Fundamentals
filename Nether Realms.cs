using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:F2} damage";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Demon> allDemons = new List<Demon>();

            string pattern = @"[-+]?[0-9]+\.?[0-9]*";

            Regex numbers = new Regex(pattern);

            string[] demons = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demon in demons)
            {
                string filter = "0123456789+-*/.";

                int health = demon.Where(c => !filter.Contains(c)).Sum(c => c);

                double damage = CalculateDamage(numbers, demon);

                allDemons.Add(new Demon { Name = demon, Health = health, Damage = damage });
            }

            foreach (var demon in allDemons.OrderBy(d => d.Name))
            {
                Console.WriteLine(demon);
            }



        }

        public static double CalculateDamage(Regex numbers, string demon)
        {
            MatchCollection numberMatches = numbers.Matches(demon);
            double damage = 0;
            foreach (Match item in numberMatches)
            {
                damage += double.Parse(item.Value);
            }

            foreach (var ch in demon)
            {
                if (ch == '*')
                {
                    damage *= 2.0;
                }
                else if (ch == '/')
                {
                    damage /= 2.0;
                }
            }
            return damage;
        }
    }
}
