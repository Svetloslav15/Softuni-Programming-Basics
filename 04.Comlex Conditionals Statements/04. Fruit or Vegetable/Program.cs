using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name = "banana" || "apple" || "kiwi" || "cherry"  || "lemon" || "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (name = "tomato"|| "cucumber" || "pepper" || "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
