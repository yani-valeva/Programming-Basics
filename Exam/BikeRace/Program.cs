using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var route = Console.ReadLine();

            var amount = 0.0;
            
            if (route == "trail")
            {
                amount = (juniors * 5.50) + (seniors * 7);
                amount -= (0.05 * amount);
            }
            else if (route == "cross-country")
            {
                if (juniors + seniors >= 50)
                {
                    amount = (juniors * 8) + (seniors * 9.50);
                    amount -= (0.25 * amount);
                    amount -= (0.05 * amount);
                }
                else
                {
                    amount = (juniors * 8) + (seniors * 9.50);
                    amount -= (0.05 * amount);
                }                
            }
            else if (route == "downhill")
            {
                amount = (juniors * 12.25) + (seniors * 13.75);
                amount -= (0.05 * amount);
            }
            else if (route == "road")
            {
                amount = (juniors * 20) + (seniors * 21.50);
                amount -= (0.05 * amount);
            }

            Console.WriteLine("{0:f2}", amount);
        }
    }
}
