using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                char[] separator = { '>', '>', '>' };
                string[] tokens = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Contains":
                        if (activationKey.IndexOf(tokens[1]) != -1)
                        {
                            Console.WriteLine("{0} contains {1}", activationKey, tokens[1]);
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":

                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        string firstPart = activationKey.Substring(0, startIndex);
                        string secondPart = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                        string thirdPart = activationKey.Substring(endIndex);

                        if (tokens[1].ToUpper() == "UPPER")
                        {
                            secondPart = secondPart.ToUpper();
                        }
                        else
                        {
                            secondPart = secondPart.ToLower();
                        }
                        activationKey = firstPart + secondPart + thirdPart;
                        Console.WriteLine(activationKey);
                        break;

                    case "Slice":
                        startIndex = int.Parse(tokens[1]);
                        endIndex = int.Parse(tokens[2]);

                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Your activation key is: {0}", activationKey);


        }
    }
}
