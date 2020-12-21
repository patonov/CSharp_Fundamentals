using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            string resourse = Console.ReadLine();

            while (resourse != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!output.ContainsKey(resourse))
                {
                    output.Add(resourse, 0);
                }
                output[resourse] += quantity;

                resourse = Console.ReadLine();
            }

            foreach (var item in output)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}
