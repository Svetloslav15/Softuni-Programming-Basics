using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Equal_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();
            name = name.ToLower();
            name1 = name1.ToLower();
            if (name == name1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");

            }
        }
    }
}
