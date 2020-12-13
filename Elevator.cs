using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;

            courses = numberOfPeople / capacity;

            if (numberOfPeople % capacity != 0 && numberOfPeople > capacity)
            {
                Console.WriteLine(courses + 1);
            }
            else if (numberOfPeople <= capacity)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(courses);
            }
        }
    }
}
