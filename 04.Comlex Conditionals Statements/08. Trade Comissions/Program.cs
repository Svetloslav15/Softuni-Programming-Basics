using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var obem = double.Parse(Console.ReadLine());
            var commision = -1.0;
            if (town == "sofia")
            {
                if (obem >= 0 && obem <= 500)
                {
                    commision = 0.05 * obem;
                }
                else if (obem > 500 && obem <= 1000)
                {
                    commision = 0.07 * obem;
                }
                else if (obem > 1000 && obem <= 10_000)
                {
                    commision = 0.08 * obem;
                }
                else if (obem > 10_000)
                {
                    commision = 0.12 * obem;
                }
            }
            else if (town == "plovdiv")
            {
                if (obem >= 0 && obem <= 500)
                {
                    commision = 0.055 * obem;
                }
                else if (obem > 500 && obem <= 1000)
                {
                    commision = 0.08 * obem;
                }
                else if (obem > 1000 && obem <= 10_000)
                {
                    commision = 0.12 * obem;
                }
                else if (obem > 10_000)
                {
                    commision = 0.145 * obem;
                }
            }
            else if (town == "varna")
            {
                if (obem >= 0 && obem <= 500)
                {
                    commision = 0.045 * obem;
                }
                else if (obem > 500 && obem <= 1000)
                {
                    commision = 0.075 * obem;
                }
                else if (obem > 1000 && obem <= 10_000)
                {
                    commision = 0.10 * obem;
                }
                else if (obem > 10_000)
                {
                    commision = 0.13 * obem;
                }
            }
            if (commision >= 0.0)
            {
                Console.WriteLine("{0:f2}",
                commision);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
