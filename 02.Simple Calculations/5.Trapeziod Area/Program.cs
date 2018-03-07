using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var S = (a + b) * h / 2;
            Console.WriteLine(S);
        }
    }
}
