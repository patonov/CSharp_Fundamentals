using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string condition = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (condition == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                    totalPrice = people * price;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                    totalPrice = people * price;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                    totalPrice = people * price;
                }

            }
            else if (condition == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                    totalPrice = people * price;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                    totalPrice = people * price;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16.00;
                    totalPrice = people * price;
                }
            }
            else if (condition == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15.00;
                    totalPrice = people * price;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20.00;
                    totalPrice = people * price;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                    totalPrice = people * price;
                }
            }
            if (condition == "Students" && people >= 30)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (condition == "Business" && people >= 100)
            {
                totalPrice = totalPrice - 10 * price;
            }
            else if (condition == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice = totalPrice - (totalPrice * 0.05);
            }


            Console.WriteLine("Total price: {0:F2}", totalPrice);


        }
    }
}
