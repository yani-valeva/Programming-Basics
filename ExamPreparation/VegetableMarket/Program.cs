using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegPrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());
            var vegKilograms = int.Parse(Console.ReadLine());
            var fruitsKilograms = int.Parse(Console.ReadLine());

            var totalVegPrice = vegPrice * vegKilograms;
            var totalFruitsPrice = fruitsPrice * fruitsKilograms;
            var totalPrice = (totalVegPrice + totalFruitsPrice) / 1.94;

            Console.WriteLine(totalPrice);
        }
    }
}
