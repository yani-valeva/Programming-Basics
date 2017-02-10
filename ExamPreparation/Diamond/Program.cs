using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = n;
            var innerDots = 3 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', innerDots));
            dots -= 1;

            for (int row = 1; row < n; row++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', innerDots));
                dots -= 1;
                innerDots += 2;
            }

            Console.WriteLine("{0}", new string('*', 5 * n));
            dots += 1;
            innerDots -= 2;

            for (int i = 2 * n; i >= 1; i--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', innerDots));
                dots += 1;
                innerDots -= 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', (5 * n) - (2 * dots)));
        }
    }
}
