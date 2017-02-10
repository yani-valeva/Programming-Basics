using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometers = int.Parse(Console.ReadLine());
            var period = Console.ReadLine();
            var price = 0.0;

            if (kilometers < 20 && period == "day")
            {
                price = 0.70 + (kilometers * 0.79);
            }
            else if (kilometers < 20 && period == "night")
            {
                price = 0.70 + (kilometers * 0.90);
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                price = kilometers * 0.09;
            }
            else if (kilometers >= 100)
            {
                price = kilometers * 0.06;
            }
            Console.WriteLine(price);
        }
    }
}
