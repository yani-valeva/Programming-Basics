using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var timePlus15Mins = minutes + 15;

            if (timePlus15Mins >= 60)
            {
                hours++;
                minutes = timePlus15Mins % 60;
                if (hours > 23)
                {
                    hours = hours - 24;
                }
                Console.WriteLine("{0}:{1:00}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1:00}", hours, timePlus15Mins);
            }          
        }
    }
}
