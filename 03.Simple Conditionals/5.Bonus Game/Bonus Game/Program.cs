using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter score:
            //Bonus score:
            //Total score:
            Console.Write("Enter score:");
            var num = double.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (num <= 100)
            {
                 bonus = 5; 
            }
            else if (num <= 1000)
            {
                bonus = bonus + 0.2 * num;
            }
             else 
            {
                 bonus = bonus + 0.1 * num;
            }
            if (num % 2 == 0)
            {
                 bonus = bonus + 1;
            }
            if (num % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.Write("Bonus score:");
            Console.WriteLine(bonus);
            Console.Write("Total score:");
            Console.WriteLine(num + bonus);

                

        }
    }
}
