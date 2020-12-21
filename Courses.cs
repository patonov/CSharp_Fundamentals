using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> couses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] commandArr = command.Split(" : ");
                string courseName = commandArr[0];
                string studentName = commandArr[1];

                if (!couses.ContainsKey(courseName))
                {
                    couses.Add(courseName, new List<string>());
                }
                couses[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            foreach (var item in couses.OrderByDescending(n => n.Value.Count))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value.Count);

                foreach (var something in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0}", something);
                }
            }
        }
    }
}
