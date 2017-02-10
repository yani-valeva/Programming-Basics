using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var dollarCourse = double.Parse(Console.ReadLine());

            var salary = workingDays * moneyPerDay;
            var moneyPerYear = (salary * 12) + (salary * 2.5);
            var totalMoney = moneyPerYear - (0.25 * moneyPerYear);
            var moneyInLeva = totalMoney * dollarCourse;
            var levaPerDay = moneyInLeva / 365;

            Console.WriteLine("{0:f2}", levaPerDay);
        }
    }
}
