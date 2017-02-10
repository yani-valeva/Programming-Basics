using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOff = int.Parse(Console.ReadLine());

            var dayOffPlay = dayOff * 127;
            var workPlay = (365 - dayOff) * 63;
            var totalPlaying = dayOffPlay + workPlay;
            var diff = Math.Abs(totalPlaying - 30000);
            var hours = diff / 60;
            var minutes = diff % 60;

            if (totalPlaying <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}
