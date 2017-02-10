using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var cargoNumbers = int.Parse(Console.ReadLine());

            var cargoCounter = 0.0;
            var counter1 = 0.0;
            var counter2 = 0.0;
            var counter3 = 0.0;

            for (int i = 0; i < cargoNumbers; i++)
            {
                var tonesCargo = int.Parse(Console.ReadLine());
                cargoCounter += tonesCargo;

                if (tonesCargo < 4)
                {
                    counter1 += tonesCargo;
                }
                else if (tonesCargo < 12)
                {
                    counter2 += tonesCargo;
                }
                else               
                {
                    counter3 += tonesCargo;
                }              
            }
            var total = ((counter1 * 200) + (counter2 * 175) + (counter3 * 120)) / cargoCounter;
            var microbus = (counter1 / cargoCounter) * 100;
            var truck = (counter2 / cargoCounter) * 100;
            var train = (counter3 / cargoCounter) * 100;

            Console.WriteLine("{0:f2}", Math.Round(total, 2));
            Console.WriteLine("{0:f2}%", microbus);
            Console.WriteLine("{0:f2}%", truck);
            Console.WriteLine("{0:f2}%", train);
        }
    }
}
