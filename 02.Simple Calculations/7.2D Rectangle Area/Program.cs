using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var rate = double.Parse(Console.ReadLine());
            var pizzaPrice = double.Parse(Console.ReadLine());
            var lasagnePrice = double.Parse(Console.ReadLine());
            var sandwichPrice = double.Parse(Console.ReadLine());
            var pizzaQuantity = double.Parse(Console.ReadLine());
            var lasagneQuantity = double.Parse(Console.ReadLine());
            var sandwichQuantity = double.Parse(Console.ReadLine());
            var allprice = (pizzaPrice*pizzaQuantity)/rate + (lasagnePrice*lasagneQuantity)/rate + (sandwichPrice*sandwichQuantity/rate);
            if (allprice >= money/rate)
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed:$ {0}", (allprice - money / rate));
            }
            else
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: $ {0}", (money-allprice / rate));
            }
          

        }
    }
}
