using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyard = int.Parse(Console.ReadLine());
            var grapes = double.Parse(Console.ReadLine());
            var wineNeeds = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var totalGrapes = vineyard * grapes;
            var wine = 0.4 * totalGrapes / 2.5;
            var diffWine = Math.Abs(wine - wineNeeds);
            var winePerPerson = diffWine / workers;

            if (wine < wineNeeds)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(diffWine));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(diffWine), Math.Ceiling(winePerPerson));
            }
        }
    }
}
