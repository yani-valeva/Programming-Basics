using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;
            var counter5 = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    counter1++;
                }
                else if (currentNumber < 400)
                {
                    counter2++;
                }
                else if (currentNumber < 600)
                {
                    counter3++;
                }
                else if (currentNumber < 800)
                {
                    counter4++;
                }
                else
                {
                    counter5++;
                }
            }
            var percent1 = counter1 * 100.0 / n;
            var percent2 = counter2 * 100.0 / n;
            var percent3 = counter3 * 100.0 / n;
            var percent4 = counter4 * 100.0 / n;
            var persent5 = counter5 * 100.0 / n;

            Console.WriteLine("{0:f2}%", percent1);
            Console.WriteLine("{0:f2}%", percent2);
            Console.WriteLine("{0:f2}%", percent3);
            Console.WriteLine("{0:f2}%", percent4);
            Console.WriteLine("{0:f2}%", persent5);
        }
    }
}
