using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches:");
            var number = double.Parse(Console.ReadLine());
            Console.Write("Centimeters:");
            Console.WriteLine(number * 2.54);


        }
    }
}
