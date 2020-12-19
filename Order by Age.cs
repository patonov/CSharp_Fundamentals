using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_by_Age
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public void Create()
        {
            return;
        }
    }


    public class Program
    {
        public static void Main()
        {

            List<string> command = Console.ReadLine().Split().ToList();
            List<Person> listOfPersons = new List<Person>();

            while (command[0] != "End")
            {
                string name = command[0].ToString();
                string id = command[1].ToString();
                int age = int.Parse(command[2]);

                var Person = new Person { Name = name, Id = id, Age = age };

                listOfPersons.Add(Person);
                command = Console.ReadLine().Split().ToList();

            }
            if (command[0] == "End")
            {
                var finalArray = listOfPersons.OrderBy(Person => Person.Age);

                foreach (var one in finalArray)
                {
                    Console.WriteLine("{0} with ID: {1} is {2} years old.", one.Name, one.Id, one.Age);
                }
            }
        }
    
