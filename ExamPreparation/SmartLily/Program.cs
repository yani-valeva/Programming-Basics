using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var laundryPrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var toyCounter = 0;
            var moneyCounter = 0;
            var money = 0.0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toyCounter++;
                }
                else
                {
                    moneyCounter++;
                    money += (moneyCounter * 10) - 1;
                }
            }
            money += toyCounter * toyPrice;

            if (money >= laundryPrice)
            {
                Console.WriteLine("Yes! {0:f2}", money - laundryPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", laundryPrice - money);
            }
        }
    }
}
