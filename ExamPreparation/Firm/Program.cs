using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var extraWorkers = int.Parse(Console.ReadLine());

            var totalDays = days - (0.1 * days);
            var timeInHours = totalDays * 8;
            var extraHours = extraWorkers * (2 * days);
            var totalHours = Math.Floor(timeInHours + extraHours);

            if (totalHours >= neededHours)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - neededHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", neededHours - totalHours);
            }
        }
    }
}
