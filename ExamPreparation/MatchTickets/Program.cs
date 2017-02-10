using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            var money = 0.0;
            var totalTicketPrice = 0.0;

            if (people <= 4)
            {
                money = budget - (0.75 * budget);
            }
            else if (people <= 9)
            {
                money = budget - (0.6 * budget);
            }
            else if (people <= 24)
            {
                money = budget - (0.5 * budget);
            }
            else if (people <= 49)
            {
                money = budget - (0.4 * budget);
            }
            else
            {
                money = budget - (0.25 * budget);
            }
            if (category == "Normal")
            {
                totalTicketPrice = people * 249.99;
            }
            else if (category == "VIP")
            {
                totalTicketPrice = people * 499.99;
            }
            if (money >= totalTicketPrice)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", money - totalTicketPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", totalTicketPrice - money);
            }
        }
    }
}
