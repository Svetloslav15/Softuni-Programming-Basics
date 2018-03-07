using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var ploshtPokrivki = a * (b + 2 * 0.3) * (c + 2 * 0.3);
            var ploshtKareta = a * (b / 2) * (b / 2);
            var priceDolari = ploshtPokrivki * 7 + ploshtKareta * 9;
            var priceleva = priceDolari * 1.85;
            Console.WriteLine("{0:F2} USD",priceDolari);
            Console.WriteLine("{0:F2} BGN",priceleva);

        }
    }
}
