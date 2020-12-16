using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int currentNumber = int.Parse(input);
                string result = IsPalindrom(currentNumber).ToString().ToLower();
                Console.WriteLine(result);
                input = Console.ReadLine();
            }

        }
        static bool IsPalindrom(int num)
        {
            int n = num;
            int dig = 0;
            int rev = 0;
            while (num > 0)
            {
                dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }
            if (n == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    }

