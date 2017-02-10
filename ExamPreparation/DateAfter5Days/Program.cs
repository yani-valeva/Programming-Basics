using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            var dayAfter5 = day + 5;

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (dayAfter5 > 30)
                {
                    dayAfter5 = dayAfter5 - 30;
                    month++;
                }
            }
            else if (month == 2)
            {
                if (dayAfter5 > 28)
                {
                    dayAfter5 = dayAfter5 - 28;
                    month++;
                }
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (dayAfter5 > 31)
                {
                    dayAfter5 = dayAfter5 - 31;
                    month++;
                }
            }
            if (month > 12)
            {
                month = month - 12;
            }
            Console.WriteLine("{0}.{1:00}", dayAfter5, month);
        }
    }
}
