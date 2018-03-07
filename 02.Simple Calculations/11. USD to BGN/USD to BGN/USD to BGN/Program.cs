using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var valuta = double.Parse(Console.ReadLine());
            string entrance = Console.ReadLine();
            string exit = Console.ReadLine();
            string hello = "BGN";
            string hello2 = "USD";
            string hello3 = "EUR";
            string hello4 = "GBP";
            double leva = 1.00000;
            double dolari = 1.79549;
            double euro = 1.95583;
            double pounds = 2.53405;
            if (entrance == hello)
            {
               if (exit == hello2)
                {
                    Console.WriteLine("{0:F2} USD", valuta / dolari);
                }
               if (exit == hello3)
                {
                    Console.WriteLine("{0:F2} EUR", valuta / euro);
                }
               if (exit == hello4)
                {
                    Console.WriteLine("{0:F2} USD", valuta / pounds);
                }
            }
            else if (entrance == hello2)
            {
                if (exit == hello)
                {
                    Console.WriteLine("{0:F2} BGN", valuta * 1.79549);

                }
                if (exit == hello3)
                {
                    Console.WriteLine("{0:F2} EUR", valuta * dolari / euro);

                }
                if (exit == hello4)
                {
                    Console.WriteLine("{0:F2} GBP", valuta * dolari / pounds);
                }
            }
            else if (entrance == hello3)
            {
                if (exit == hello)
                {
                    Console.WriteLine("{0:F2} BGN", valuta * euro);
                }
                if (exit == hello2)
                {
                    Console.WriteLine("{0:F2} USD", valuta * euro / dolari);
                }
                if (exit == hello4)
                {
                    Console.WriteLine("{0:F2} GBP", valuta * euro / pounds);

                }

            }
            else if (entrance == hello4)
            {
                if (exit == hello)
                {
                    Console.WriteLine("{0:F2} BGN", valuta * pounds);

                }
                if (exit == hello2)
                {
                    Console.WriteLine("{0:F2} USD", valuta * pounds / dolari);

                }
                if (exit == hello3)
                {
                    Console.WriteLine("{0:F2} EUR", valuta* pounds / euro);

                }
            }
        }
    }
}
