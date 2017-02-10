using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfterFiveDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var dayAfterfiveDays = day + 5;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (dayAfterfiveDays > 31)
                    {
                        month++;
                        dayAfterfiveDays = dayAfterfiveDays - 31;
                    }
                    if (month > 12)
                    {
                        month = month - 12;
                    }
                    break;
                case 2:
                    if (dayAfterfiveDays > 28)
                    {
                        month++;
                        dayAfterfiveDays = dayAfterfiveDays - 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dayAfterfiveDays > 30)
                    {
                        month++;
                        dayAfterfiveDays = dayAfterfiveDays - 30;
                    }
                    break;
            }
            Console.WriteLine("{0}.{1:00}", dayAfterfiveDays, month);
        }
    }
}
