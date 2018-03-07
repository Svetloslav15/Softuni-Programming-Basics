using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            string male = "m";
            string female = "f";
            if (age < 16)
            {
                if (sex == male)
                {
                    Console.WriteLine("Master");
                }
                else if (sex == female)
                {
                    Console.WriteLine("Miss");

                }
            }
            else if (age >= 16)
            {
                if (sex == male)
                {
                    Console.WriteLine("Mr.");
                }
                else if (sex == female )
                {
                    Console.WriteLine("Ms.");
                }
            }

        }
    }
}
