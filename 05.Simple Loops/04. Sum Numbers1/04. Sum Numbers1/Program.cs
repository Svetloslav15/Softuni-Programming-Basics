using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
            
        }
    }
}
