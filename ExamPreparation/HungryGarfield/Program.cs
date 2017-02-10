using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyInDollars = decimal.Parse(Console.ReadLine());
            var exchangeRate = decimal.Parse(Console.ReadLine());
            var pizzaLv = decimal.Parse(Console.ReadLine());
            var lasagnaLv = decimal.Parse(Console.ReadLine());
            var sandwichLv = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());

            var pizzaDollars = (pizzaLv / exchangeRate) * pizzaQuantity;
            var lasagnaDollars = (lasagnaLv / exchangeRate) * lasagnaQuantity;
            var sandwichDollars = (sandwichLv / exchangeRate) * sandwichQuantity;
            var totalInDollars = pizzaDollars + lasagnaDollars + sandwichDollars;

            if (totalInDollars <= moneyInDollars)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyInDollars - totalInDollars);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", totalInDollars - moneyInDollars);
            }
        }
    }
}
