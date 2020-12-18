using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = Console.ReadLine().Split().Select(int.Parse).ToList();


            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArg = command.Split();
                string firstArgument = commandArg[0];
                int element = int.Parse(commandArg[1]);

                if (firstArgument == "Delete")
                {
                    listOfInts.RemoveAll(x => x == element);
                }
                else if (firstArgument == "Insert")
                {
                    int position = int.Parse(commandArg[2]);
                    listOfInts.Insert(position, element);
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listOfInts));

        }
    }
}
