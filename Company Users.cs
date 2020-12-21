using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyPeople = new Dictionary<string, List<string>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                else
                {
                    string[] input = line.Split(" -> ");
                    string companyName = input[0];
                    string employeeId = input[1];
                    if (!companyPeople.ContainsKey(companyName))
                    {
                        companyPeople.Add(companyName, new List<string>());
                        companyPeople[companyName].Add(employeeId);
                    }
                    else
                    {

                        companyPeople[companyName].Add(employeeId);


                    }
                }
            }
            Dictionary<string, List<string>> sortedCompany = companyPeople
                  .OrderBy(x => x.Key)

                  .ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var kvp in sortedCompany)
            {
                kvp.Value.Sort();
            }
            foreach (var kvp in sortedCompany)
            {
                for (int i = 0; i < kvp.Value.Count - 1; i++)

                {
                    if (kvp.Value[i] == kvp.Value[i + 1])
                    {
                        companyPeople[kvp.Key].Remove(kvp.Value[i + 1]);
                        i = -1;
                    }


                }
            }
            foreach (var kvp in sortedCompany)
            {
                Console.WriteLine($"{kvp.Key}");
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }

            }
        }
    }
    }
