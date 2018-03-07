using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_the_range__1_100_
{
    class Program
    {
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a number in the range [1...100]: ");
                int n = int.Parse(Console.ReadLine());
                while (n > 100 || n < 1)
                {
                    Console.WriteLine("Invalid number!");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The number is: " + n);
            }
        }
    }

}
    }
}
