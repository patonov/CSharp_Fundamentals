using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstClerk = int.Parse(Console.ReadLine());
            int secondClerk = int.Parse(Console.ReadLine());
            int thirdClerk = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int studentsServedPerHour = firstClerk + secondClerk + thirdClerk;
            int hours = 0;


            while (students > 0)
            {
                students -= studentsServedPerHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
            Console.WriteLine("Time needed: {0}h.", hours);

        }
    }
}
