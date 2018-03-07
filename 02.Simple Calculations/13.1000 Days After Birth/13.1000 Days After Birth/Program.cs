using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString, format;
            dateString = "15/03/2002";
            format = "dd mm yyyy"; 

            DateTime birthday = "15 / 03 / 2002";
            DateTime answer = birthday.AddDays(1000);
            Console.WriteLine(answer);
            

        }
    }
}
