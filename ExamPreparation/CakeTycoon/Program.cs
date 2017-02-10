using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong wantedCakes = ulong.Parse(Console.ReadLine());
            double neededFlourForCake = double.Parse(Console.ReadLine());
            uint availableFlour = uint.Parse(Console.ReadLine());
            uint availableTruffles = uint.Parse(Console.ReadLine());
            uint trufflesPrice = uint.Parse(Console.ReadLine());

            double cakes = Math.Floor(availableFlour / neededFlourForCake);
            ulong totalTrufflesPrice = (ulong)availableTruffles * trufflesPrice;

            if (wantedCakes <= cakes)
            {
                double cakePrice = ((double)totalTrufflesPrice / wantedCakes) * 1.25d;
                Console.WriteLine("All products available, price of a cake: {0:f2}", cakePrice);
            }
            else
            {
                double totalNeededFlour = wantedCakes * neededFlourForCake;
                double flourDiff = totalNeededFlour - availableFlour;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", cakes, flourDiff);
            }
        }
    }
}
