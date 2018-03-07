using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            var prime = true;


            for (var i = 2; i <= Math.Sqrt(n); i++)
                if (n <= 0)
                {
                    prime = true;
                }


                else if (n % i == 0)
                {


                    prime = false;


                    break;


                }


            if (prime == true)
            {
                Console.WriteLine("Not Prime");

            }
            else if (prime == false)
            {
                Console.WriteLine("Prime");
            }
        }
    }
}