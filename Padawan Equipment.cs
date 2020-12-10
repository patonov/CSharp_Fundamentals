using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double equipmentCost = 0;

            equipmentCost = Math.Ceiling(students * 1.1) * lightsabersPrice;
            equipmentCost += students * robesPrice;
            equipmentCost += students * beltsPrice;

            if (students >= 6)
            {
                equipmentCost = equipmentCost - (students / 6 * beltsPrice);
            }

            if (equipmentCost <= money)
            {
                Console.WriteLine("The money is enough - it would cost {0:F2}lv.", equipmentCost);
            }
            else
            {
                double difference = money - equipmentCost;
                Console.WriteLine("Ivan Cho will need {0:F2}lv more.", Math.Abs(difference));
            }
        }
    }
}
