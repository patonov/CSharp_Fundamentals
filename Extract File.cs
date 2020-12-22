using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\');

            var file = input[input.Length - 1];

            var fileArr = file.Split('.');

            var fileName = fileArr[0];
            var fileExtension = fileArr[1];

            Console.WriteLine("File name: {0}", fileName);
            Console.WriteLine("File extension: {0}", fileExtension);


        }
    }
}
