using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine().ToLower();
            var productQuantity = double.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(0.5 * productQuantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(0.4 * productQuantity);
                }
                if (town == "varna")
                {
                    Console.WriteLine(0.45 * productQuantity);
                }
            }
            else if (product == "water")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(0.8 * productQuantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(0.7 * productQuantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(0.7 * productQuantity);
                }
            }
            else if(product == "beer")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(1.2 * productQuantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(1.15 * productQuantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(1.1 * productQuantity);
                }
            }
            else if ( product == "sweets")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(1.45 * productQuantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(1.3 * productQuantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(1.35 * productQuantity);
                }
            }
            else if(product == "peanuts")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(1.6 * productQuantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(1.5 * productQuantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(1.55 * productQuantity);
                }
            }
           


        }
    }
}
