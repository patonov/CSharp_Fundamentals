using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int peopleCount = int.Parse(Console.ReadLine());

            int totalPeoplePerHour = first + second + third;
            int hours = 0;

            while (peopleCount > 0)
            {
                peopleCount -= totalPeoplePerHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours += 1;
                }
            }
            Console.WriteLine("Time needed: {0}h.", hours);

        }
    }
}
