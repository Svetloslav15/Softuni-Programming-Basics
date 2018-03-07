using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f = 1;
            while (n > 1)
            {
                f *= n;
                n--;
            }
            Console.WriteLine(f);
            this.Fokus();
        }
    }
}
