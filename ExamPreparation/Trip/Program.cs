using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var spentMoney = 0.0;

            if (money <= 100 && season == "summer")
            {
                spentMoney = 0.3 * money;
                Console.WriteLine("Somewhere in Bulgaria");
            }
            else if (money <= 100 && season == "winter")
            {
                spentMoney = 0.7 * money;
                Console.WriteLine("Somewhere in Bulgaria");
            }
            else if (money <= 1000 && season == "summer")
            {
                spentMoney = 0.4 * money;
                Console.WriteLine("Somewhere in Balkans");
            }
            else if (money <= 1000 && season == "winter")
            {
                spentMoney = 0.8 * money;
                Console.WriteLine("Somewhere in Balkans");
            }
            else if (money > 1000)
            {
                spentMoney = 0.9 * money;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", spentMoney);
            }
            if (money <= 1000 && season == "summer")
            {
                Console.WriteLine("Camp - {0:f2}", spentMoney);
            }
            else if (money <= 1000 && season == "winter")
            {
                Console.WriteLine("Hotel - {0:f2}", spentMoney);
            }
        }
    }
}
