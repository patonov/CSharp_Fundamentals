using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> output = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] comandArr = Console.ReadLine().Split();
                string task = comandArr[0];
                string userName = comandArr[1];

                if (task == "register")
                {
                    string licensePlateNumber = comandArr[2];

                    if (!output.ContainsKey(userName))
                    {
                        output.Add(userName, licensePlateNumber);
                        Console.WriteLine("{0} registered {1} successfully", userName, licensePlateNumber);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", licensePlateNumber);
                    }
                }
                else if (task == "unregister")
                {
                    if (!output.ContainsKey(userName))
                    {
                        Console.WriteLine("ERROR: user {0} not found", userName);
                    }
                    else
                    {
                        output.Remove(userName);
                        Console.WriteLine("{0} unregistered successfully", userName);
                    }
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value);
            }


        }
    }
}
