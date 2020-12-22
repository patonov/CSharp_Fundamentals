using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (currentChar == '>')
                {
                    bomb += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if (bomb > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }
            Console.WriteLine(input);





        }
    }
}
