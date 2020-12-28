using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '|' }).ToArray();
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new List<string>());
                    pieces[piece].Add(composer);
                    pieces[piece].Add(key);
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArr = command.Split(new char[] { '|' }).ToArray();
                string piece = commandArr[1];


                if (commandArr[0] == "Add")
                {
                    string composer = commandArr[2];
                    string key = commandArr[3];
                    if (!pieces.ContainsKey(piece))
                    {
                        string pieceAdded = piece;
                        pieces.Add(pieceAdded, new List<string>());
                        pieces[piece].Add(composer);
                        pieces[piece].Add(key);
                        Console.WriteLine("{0} by {1} in {2} added to the collection!", pieceAdded, pieces[piece][0], pieces[piece][1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is already in the collection!", piece);
                    }
                }
                else if (commandArr[0] == "Remove")
                {
                    string pieceForRemove = piece;
                    if (pieces.ContainsKey(pieceForRemove))
                    {
                        pieces.Remove(pieceForRemove);
                        Console.WriteLine("Successfully removed {0}!", pieceForRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation! {0} does not exist in the collection.", pieceForRemove);
                    }
                }
                else if (commandArr[0] == "ChangeKey")
                {
                    string pieceForChange = piece;
                    if (pieces.ContainsKey(pieceForChange))
                    {
                        string keyReplaced = commandArr[2];
                        pieces[pieceForChange][1] = keyReplaced;
                        Console.WriteLine("Changed the key of {0} to {1}!", pieceForChange, keyReplaced);
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation! {0} does not exist in the collection.", pieceForChange);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var piece in pieces.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine("{0} -> Composer: {1}, Key: {2}", piece.Key, piece.Value[0], piece.Value[1]);
            }

        }
    }
}
