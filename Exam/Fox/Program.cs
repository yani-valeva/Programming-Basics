using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            var innerDash = (2 * n) - 1;
            var dashOut = 1;
            var innerStars = (2 * n) - 1;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', stars), new string('-', innerDash));
                stars += 1;
                innerDash -= 2;
            }

            stars -= 1;
            for (int row = 1; row <= n / 3; row++)
            {
                var starsOut = ((2 * n) - (1 + stars)) / 2;
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', starsOut), new string('*', stars));
                starsOut += 1;
                stars -= 2;
            }

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', dashOut), new string('*', innerStars));
                dashOut += 1;
                innerStars -= 2;
            }
        }
    }
}
