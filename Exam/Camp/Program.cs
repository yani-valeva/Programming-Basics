using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupNumbers = int.Parse(Console.ReadLine());

            var carCounter = 0.0;
            var microBusCounter = 0.0;
            var miniBusCounter = 0.0;
            var busCounter = 0.0;
            var trainCounter = 0.0;
            var totalpeoples = 0;

            for (int i = 0; i < groupNumbers; i++)
            {
                var peopleNumbers = int.Parse(Console.ReadLine());
                totalpeoples += peopleNumbers;

                if (peopleNumbers <= 5)
                {
                    carCounter += peopleNumbers;
                }
                else if (peopleNumbers >= 6 && peopleNumbers <= 12)
                {
                    microBusCounter += peopleNumbers;
                }
                else if (peopleNumbers >= 13 && peopleNumbers <= 25)
                {
                    miniBusCounter += peopleNumbers;
                }
                else if (peopleNumbers >= 26 && peopleNumbers <= 40)
                {
                    busCounter += peopleNumbers;
                }
                else
                {
                    trainCounter += peopleNumbers;
                }
            }

            var carPercent = (carCounter / totalpeoples) * 100.0;
            var microBusPercent = (microBusCounter / totalpeoples) * 100.0;
            var miniBusPercent = (miniBusCounter / totalpeoples) * 100.0;
            var busPercent = (busCounter / totalpeoples) * 100.0;
            var trainPercent = (trainCounter / totalpeoples) * 100.0;

            Console.WriteLine("{0:f2}%", carPercent);
            Console.WriteLine("{0:f2}%", microBusPercent);
            Console.WriteLine("{0:f2}%", miniBusPercent);
            Console.WriteLine("{0:f2}%", busPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }
    }
}
