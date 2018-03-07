using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter even number: ");
            int n = int.Parse(Console.ReadLine());
            while (n % 2 != 0)
            {
                Console.WriteLine("The number is not even.");
                 n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Even number entered: " + n);

        }
    }
}

