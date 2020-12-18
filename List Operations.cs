using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArray = command.Split();
                string commandLiteral = commandArray[0];

                if (commandLiteral == "Add")
                {
                    int commandAddNumber = int.Parse(commandArray[1]);
                    numbers.Add(commandAddNumber);
                }
                else if (commandLiteral == "Insert")
                {
                    int commandInsertNumber = int.Parse(commandArray[1]);
                    int commandInsertIndex = int.Parse(commandArray[2]);

                    if (commandInsertIndex > commandInsertNumber || commandInsertIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(commandInsertNumber, commandInsertIndex);
                    }
                }
                else if (commandLiteral == "Remove")
                {
                    int commandRemoveIndex = int.Parse(commandArray[1]);

                    if (commandRemoveIndex > numbers.Count || commandRemoveIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(commandRemoveIndex);
                    }
                }
                else if (commandLiteral == "Shift")
                {
                    int rotation = int.Parse(commandArray[2]);

                    if (commandArray[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElement = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastElement;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
