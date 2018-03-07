using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());
            var priceQuantity = -1.00;
            if (day == "monday" || day == "tuesday" ||
                day == "wednesday" || day == "thursday" || day == "friday")
                {
                    if (fruit == "banana")
                    {
                        priceQuantity = 2.5;
                    }
                    else if(fruit == "apple")
                    {
                        priceQuantity = 1.2;
                    }
                    if (fruit == "orange")
                    {
                        priceQuantity = 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        priceQuantity = 1.45;
                    }
                    if (fruit == "kiwi")
                    {
                        priceQuantity = 2.7;
                    }
                    else if (fruit == "pineapple")
                    {
                        priceQuantity = 5.5;
                    }
                    else if (fruit == "grapes")
                    {
                        priceQuantity = 3.85;
                    }
            } 
            else if (day == "sunday" || day == "saturday")
            {
                if (fruit == "banana")
                {
                    priceQuantity = 2.7;
                }
                else if (fruit == "apple")
                {
                    priceQuantity = 1.25;
                }
                if (fruit == "orange")
                {
                    priceQuantity = 0.9;
                }
                else if (fruit == "grapefruit")
                {
                    priceQuantity = 1.6;
                }
                if (fruit == "kiwi")
                {
                    priceQuantity = 3.0;
                }
                else if (fruit == "pineapple")
                {
                    priceQuantity = 5.6;
                }
                else if (fruit == "grapes")
                {
                    priceQuantity = 4.2;
                }
            }
            if (priceQuantity >= 0.0)
            {
                Console.WriteLine(priceQuantity * amount);
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
