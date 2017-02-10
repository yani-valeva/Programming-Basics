using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var mackerelPrice = double.Parse(Console.ReadLine());
            var spratPrice = double.Parse(Console.ReadLine());
            var beltedKg = double.Parse(Console.ReadLine());
            var scadKg = double.Parse(Console.ReadLine());
            var clamsKg = int.Parse(Console.ReadLine());

            var beltedPrice = mackerelPrice + (mackerelPrice * 0.60);
            var totalBeltedPrice = beltedKg * beltedPrice;
            var scadPrice = spratPrice + (spratPrice * 0.80);
            var totalScadPrice = scadKg * scadPrice;
            var totalClamsPrice = clamsKg * 7.50;
            var totalMoney = totalBeltedPrice + totalScadPrice + totalClamsPrice;

            Console.WriteLine("{0:f2}", Math.Round(totalMoney, 2));
        }
    }
}
