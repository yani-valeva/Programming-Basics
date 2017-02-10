using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dots = n + 1;
            var dashes = (2 * n) + 1;

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', dashes));
            dots -= 1;
            dashes -= 2;

            for (int row = 0; row <= n; row++)
            {
                if (row == n)
                {
                    Console.WriteLine("{0}//{1}STOP!{1}\\\\{0}", new string('.', dots), new string('_', (dashes - 5) / 2));
                }
                else
                {
                    Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', dashes));

                    dots -= 1;
                    dashes += 2;
                }
            }

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', dashes));

                dots += 1;
                dashes -= 2;
            }
        }
    }
}
