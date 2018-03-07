using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a = double.Parse(Console.ReadLine());
            Console.Write("S=");
            Console.WriteLine(a * a);
        }
    }
}
