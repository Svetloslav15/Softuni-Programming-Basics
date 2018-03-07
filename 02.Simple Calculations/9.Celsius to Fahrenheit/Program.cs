using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = a * 1.8 + 32;
            Console.WriteLine(b);
        }
    }
}
