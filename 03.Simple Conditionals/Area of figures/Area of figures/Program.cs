using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var a = double.Parse(Console.ReadLine());
            var circle = "circle";
            var triangle = "triangle";
            var square = "square";
            var rectangle = "rectangle";
            if (figure == square)
            {
                Console.WriteLine(a * a);
            }
            else if (figure == circle)
            {
                Console.WriteLine("{0:F3}",Math.PI * a * a);
            }

            

            
            else if (figure == rectangle)
            {
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }


            else if (figure == triangle)
            {
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine((a * b / 2));
            }
        }
    }
}

                
        
    

