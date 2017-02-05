using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Mins1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var timeAfter15 = (hours * 60) + minutes + 15;
            var totalHours = timeAfter15 / 60;
            var totalMins = timeAfter15 % 60;

            if (totalHours == 24)
            {
                totalHours = 0;
            }
            Console.WriteLine("{0}:{1:00}", totalHours, totalMins);
        }
    }
}
