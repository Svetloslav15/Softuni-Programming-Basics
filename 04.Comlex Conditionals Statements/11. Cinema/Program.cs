using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            if (type == "premiere")
            {
                Console.WriteLine("{0:f2} leva", width * height * 12.0);
            }
            else if (type == "normal")
            {
                Console.WriteLine("{0:f2} leva", width * height * 7.5);
            }
            else if( type == "discount")
            {
                Console.WriteLine("{0:f2} leva", width * height * 5.0);
            }

        }
    }
}
