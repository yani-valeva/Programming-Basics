using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamItem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string month = input[0];
            decimal moneyPerHour = decimal.Parse(input[1]);
            decimal hoursPerDay = decimal.Parse(input[2]);
            decimal itemPrice = decimal.Parse(input[3]);

            var days = 0;
            switch (month)
            {
                case "Feb":
                    days = 28;
                    break;
                case "Apr":
                case "June":
                case "Sept":
                case "Nov":
                    days = 30;
                    break;
                case "Jan":
                case "March":
                case "May":
                case "July":
                case "Aug":
                case "Oct":
                case "Dec":
                    days = 31;
                    break;
            }

            var workingDays = days - 10;

            decimal totalMoney = workingDays * moneyPerHour * hoursPerDay;

            if (totalMoney > 700)
            {
                totalMoney += totalMoney * 0.1m;
            }

            if (totalMoney - itemPrice >= 0)
            {
                Console.WriteLine("Money left = {0:f2} leva.", totalMoney - itemPrice);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:f2} leva needed.", itemPrice - totalMoney);
            }
        }
    }
}
