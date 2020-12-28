using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\#|\|)([A-Z a-z]+)(\#|\|)(\d{2}\/\d{2}\/\d{2})(\#|\|)([0-9]+)(\#|\|)";

            int totalCalories = 0;


            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string calories = match.Groups[6].Value;
                totalCalories += int.Parse(calories);
            }

            int caloriesForDays = totalCalories / 2000;

            Console.WriteLine("You have food to last you for: {0} days!", caloriesForDays);

            foreach (Match match in matches)
            {
                string productName = match.Groups[2].Value;
                string date = match.Groups[4].Value;
                string calories = match.Groups[6].Value;
                Console.WriteLine("Item: {0}, Best before: {1}, Nutrition: {2}", productName, date, calories);
            }
        }
    }
}
