using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                sum += number;
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum -max));
            }
        }
    }
}
