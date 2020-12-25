using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commandArr = input.Split();
                string command = commandArr[0];
                if (command == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(commandArr[1]);
                    int length = int.Parse(commandArr[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = commandArr[1];
                    string substiture = commandArr[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substiture);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Your password is: {0}", password);

        }
    }
}
