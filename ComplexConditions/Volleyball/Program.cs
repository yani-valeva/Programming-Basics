using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsInHometown = int.Parse(Console.ReadLine());

            var weekendsInSofia = 48 - weekendsInHometown;
            var playingInSofia = weekendsInSofia * 3 / 4.0;
            var playingInHometown = weekendsInHometown;
            var playingInHolidays = holidays * 2 / 3.0;
            var playingInNormalYear = playingInSofia + playingInHometown + playingInHolidays;

            if (year == "leap")
            {
                var extraPlaying = 0.15 * playingInNormalYear;
                var playingInLeapYear = playingInNormalYear + extraPlaying;
                Console.WriteLine(Math.Floor(playingInLeapYear));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(playingInNormalYear));
            }
        }
    }
}
