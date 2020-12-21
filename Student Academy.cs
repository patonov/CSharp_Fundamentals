using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> listOfGrades = new Dictionary<string, List<double>>();

            string studentName = string.Empty;
            double studentGrade = 0;


            for (int i = 0; i < rows; i++)
            {
                studentName = Console.ReadLine();
                studentGrade = double.Parse(Console.ReadLine());

                if (!listOfGrades.ContainsKey(studentName))
                {

                    listOfGrades.Add(studentName, new List<double>());

                }

                listOfGrades[studentName].Add(studentGrade);

            }

            foreach (var student in listOfGrades.OrderByDescending(x => x.Value.Average()))
            {

                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine("{0} -> {1:f2}", student.Key, student.Value.Average());
                }
            }
        }
    }
}
