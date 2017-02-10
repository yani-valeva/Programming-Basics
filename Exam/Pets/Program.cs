using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodKg = int.Parse(Console.ReadLine());
            var dogFoodKg = double.Parse(Console.ReadLine());
            var catFoodKg = double.Parse(Console.ReadLine());
            var turtleFoodG = double.Parse(Console.ReadLine());

            var totalDogFood = days * dogFoodKg;
            var totalCatFood = days * catFoodKg;
            var totalTurtleFood = days * turtleFoodG / 1000;
            var totalFood = totalDogFood + totalCatFood + totalTurtleFood;
            var foodDiff = Math.Abs(totalFood - foodKg);

            if (totalFood <= foodKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodDiff));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodDiff));
            }
        }
    }
}
