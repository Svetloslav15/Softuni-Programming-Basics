using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weeksInSofia = 48 - h;
            var gamesInWeekendsInSofia = weeksInSofia * (3.0 / 4);
            var gamesInRodenGrad = h;
            var gamesInPrDays = p * (2.0 / 3);
            var allgames = gamesInPrDays + gamesInRodenGrad + gamesInWeekendsInSofia;
            if (type == "leap")
            {
                allgames = allgames + 0.15 * allgames;

            }
            else
            {
                allgames = gamesInPrDays + gamesInRodenGrad + gamesInWeekendsInSofia;
            }
            Console.WriteLine(Math.Truncate(allgames));




        }
    }
}
