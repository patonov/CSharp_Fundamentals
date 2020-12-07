using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            var time = new TimeSpan(hours, minutes + 30, 0);
            Console.WriteLine("{0:h\\:mm}", time);

        }
    }
}
