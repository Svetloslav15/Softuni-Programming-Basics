using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int max = int.MinValue;
            int min = int.MaxValue;
            int average = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
               {
                if (max < i)
                {
                    max = i;
                }

                if (i < min)
                {
                    min = i;
                }
                sum += nums[i];
                average = nums.Average;
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
        }
    }
}
