using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hiddenMessage = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                char[] separator = { ':', '|', ':' };
                string[] inputArr = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(inputArr[1]);
                    hiddenMessage = hiddenMessage.Insert(index, " ");
                    Console.WriteLine(hiddenMessage);
                }
                else if (command == "Reverse")
                {
                    string substring = inputArr[1];

                    if (hiddenMessage.Contains(substring))
                    {
                        int substringIndex = hiddenMessage.IndexOf(substring);
                        hiddenMessage = hiddenMessage.Remove(substringIndex, hiddenMessage.Length - substringIndex);
                        string reversedSubstring = string.Empty;
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversedSubstring += substring[i];
                        }
                        hiddenMessage += reversedSubstring;
                        Console.WriteLine(hiddenMessage);

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substringForReplacing = inputArr[1];
                    string replacement = inputArr[2];
                    hiddenMessage = hiddenMessage.Replace(substringForReplacing, replacement);

                    Console.WriteLine(hiddenMessage);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("You have a new text message: {0}", hiddenMessage);
        }
    }
}
