using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string guestName = commands[0];

                if (commands.Length > 3)
                {
                    if (guests.Contains(guestName))
                    {
                        guests.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not in the list!", guestName);
                    }
                }
                else
                {
                    if (!guests.Contains(guestName))
                    {
                        guests.Add(guestName);
                    }
                    else
                    {
                        Console.WriteLine("{0} is already in the list!", guestName);
                    }
                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));

        }
    }
}
