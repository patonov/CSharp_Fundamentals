using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                char[] separator = { '|' };
                string[] commandArr = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string commandForDoing = commandArr[0];

                if (commandForDoing == "Move")
                {
                    int numberOfLetters = int.Parse(commandArr[1]);
                    string substring = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message += substring;
                }
                else if (commandForDoing == "Insert")
                {
                    int index = int.Parse(commandArr[1]);
                    string valueForInsert = commandArr[2];
                    message = message.Insert(index, valueForInsert);
                }
                else if (commandForDoing == "ChangeAll")
                {
                    string substring = commandArr[1];
                    string replacement = commandArr[2];
                    message = message.Replace(substring, replacement);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("The decrypted message is: {0}", message);
        }
    }
}
