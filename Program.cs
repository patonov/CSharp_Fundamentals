using System;

public class Program
{
    public static void Main()
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
            }
            else if (command == "Reverse")
            {
                string substring = inputArr[1];

                if (hiddenMessage.Contains(substring))
                {
                    int substringIndex = hiddenMessage.IndexOf(substring);
                    hiddenMessage = hiddenMessage.Remove(substringIndex, hiddenMessage.Length - substringIndex);
                    string reversedSubstring = string.Empty;
                    for (int i = substring.Length - 1; i > 0; i--)
                    {
                        reversedSubstring += substring[i];
                    }
                    hiddenMessage += reversedSubstring;

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
            }

            input = Console.ReadLine();
        }
        Console.WriteLine("You have a new text message: {0}", hiddenMessage);
    }
}