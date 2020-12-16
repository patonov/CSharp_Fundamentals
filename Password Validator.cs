using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();

            bool isTrue = ValidateLenght(passWord) && ValidateLettersAndDigits(passWord) && ValidateHavingTwoDigits(passWord);

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidateLenght(passWord))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!ValidateLettersAndDigits(passWord))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!ValidateHavingTwoDigits(passWord))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }

        }


        static bool ValidateLenght(string word)
        {
            if (word.Length >= 6 && word.Length <= 10)
            {
                bool isTrue = true;
                return isTrue;
            }
            return false;
        }

        static bool ValidateLettersAndDigits(string word)
        {
            foreach (char c in word)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;

        }

        static bool ValidateHavingTwoDigits(string word)
        {
            int count = 0;
            foreach (char c in word)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
