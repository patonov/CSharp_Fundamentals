using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                char[] separator = { ':' };
                string[] commandArr = command.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArr[0] == "Add Stop")
                {

                    int index = int.Parse(commandArr[1]);
                    string substring = commandArr[2];

                    if (index < input.Length)
                    {
                        input = input.Insert(index, substring);
                    }
                    Console.WriteLine(input);
                }
                else if (commandArr[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);
                    int count = endIndex - startIndex;

                    if (startIndex < input.Length && endIndex < input.Length && startIndex + count > 0)
                    {
                        input = input.Remove(startIndex, count + 1);
                    }
                    Console.WriteLine(input);
                }
                else if (commandArr[0] == "Switch")
                {
                    string oldString = commandArr[1];
                    string newString = commandArr[2];

                    if (input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                    }
                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Ready for world tour! Planned stops: {0}", input);


        }
    }
}
