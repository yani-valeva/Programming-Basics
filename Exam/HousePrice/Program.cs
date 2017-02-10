using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallest = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var secondRoom = smallest + (0.1 * smallest);
            var thirdRoom = secondRoom + (0.1 * secondRoom);
            var bathroom = smallest / 2;
            var area = smallest + kitchen + secondRoom + thirdRoom + bathroom;
            var totalArea = area + (0.05 * area);
            var totalPrice = totalArea * price;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
