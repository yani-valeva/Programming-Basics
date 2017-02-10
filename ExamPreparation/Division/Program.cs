using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    counter1++;
                }
                if (currentNumber % 3 == 0)
                {
                    counter2++;
                }
                if (currentNumber % 4 == 0)
                {
                    counter3++;
                }
            }

            var percent1 = counter1 * 100.0 / n;
            var percent2 = counter2 * 100.0 / n;
            var percent3 = counter3 * 100.0 / n;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%", percent1, percent2, percent3);
        }
    }
}
