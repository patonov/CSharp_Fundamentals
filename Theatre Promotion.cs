using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            if (day == "weekday")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (64 < age && age <= 122)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "weekend")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (64 < age && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "holiday")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (64 < age && age <= 122)
                {
                    Console.WriteLine("10$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
