﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeld = int.Parse(Console.ReadLine());
            int collect = 0;
            int days = 0;
            if (yeld >= 100)
            {
                while (yeld >= 100)
                {
                    days++;
                    collect += yeld;
                    yeld -= 10;

                }
                collect -= (days + 1) * 26;
                Console.WriteLine(days);
                Console.WriteLine(collect);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(collect);
            }
        }
    }
}
