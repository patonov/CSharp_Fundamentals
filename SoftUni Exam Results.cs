using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] commArr = input.Split('-');
                string userName = commArr[0];
                if (commArr.Length > 2)
                {
                    string language = commArr[1];
                    int points = int.Parse(commArr[2]);
                    if (!students.ContainsKey(userName))
                    {
                        students.Add(userName, points);
                    }
                    else
                    {
                        if (students[userName] < points)
                        {
                            students[userName] = points;
                        }
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                else
                {
                    students.Remove(userName);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var student in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} | {1}", student.Key, student.Value);
            }

            Console.WriteLine("Submissions:");
            foreach (var submit in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} - {1}", submit.Key, submit.Value);
            }

        }
    }
}
