using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int copy = n;
            int sum = 0;
            while (copy > 0)
            {
                sum += copy % 10;
                copy = copy / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
