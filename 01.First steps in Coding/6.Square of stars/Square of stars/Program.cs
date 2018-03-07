using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num - 2; i++)
                Console.WriteLine(new string('*', i));
        }
    }
}
