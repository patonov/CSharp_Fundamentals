using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string passWord = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {

                passWord += userName[i];
            }

            int count = 0;

            while (true)
            {
                string currentUser = Console.ReadLine();

                if (currentUser == passWord)
                {
                    Console.WriteLine("User {0} logged in.", userName);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    count++;
                    if (count >= 3)
                    {
                        Console.WriteLine("User {0} blocked!", userName);
                        break;
                    }

                }


            }
        }
    }
}
