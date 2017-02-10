using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftDashes = 3 * n;
            var innerDashes = 0;
            var rightDashes = (5 * n) - ((3 * n) + 2);

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', innerDashes), new string('-', rightDashes));
                innerDashes += 1;
                rightDashes -= 1;
            }

            innerDashes -= 1;
            rightDashes += 1;

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes), new string('-', innerDashes), new string('-', rightDashes));
            }

            for (int row = 1; row <= n / 2; row++)
            {
                if (row == n / 2)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', innerDashes), new string('-', rightDashes));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', innerDashes), new string('-', rightDashes));
                    leftDashes -= 1;
                    rightDashes -= 1;
                    innerDashes += 2;
                }
            }
        }
    }
}
