using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = headSetPrice * (lostGames / 2);
            money += mousePrice * (lostGames / 3);
            money += keyboardPrice * (lostGames / 6);
            money += displayPrice * (lostGames / 12);

            Console.WriteLine("Rage expenses: {0:F2} lv.", money);
        }
    }
}
