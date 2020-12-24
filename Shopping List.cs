using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> grocerList = Console.ReadLine().Split('!').ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string item = commandArgs[1];
                if (command == "Urgent")
                {
                    if (!grocerList.Contains(item))
                    {
                        grocerList.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    grocerList.Remove(item);
                }
                else if (command == "Correct")
                {
                    string newItem = commandArgs[2];
                    if (grocerList.Contains(item))
                    {
                        int index = grocerList.FindIndex(x => x == item);
                        grocerList.RemoveAt(index);
                        grocerList.Insert(index, newItem);
                    }

                }
                else if (command == "Rearrange")
                {
                    if (grocerList.Contains(item))
                    {
                        grocerList.Remove(item);
                        grocerList.Add(item);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", grocerList));

        }
    }
}
