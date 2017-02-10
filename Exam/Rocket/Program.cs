using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = ((3 * n) - 2) / 2;
            var spaces = 0;         

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dots), new string(' ', spaces));
                dots -= 1;
                spaces += 2;
            }
            dots += 1;

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', 2 * n));

            var backslash = (3 * n) - ((2 * dots) + 2);

            for (int row = 1; row <= 2 * n; row++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', dots), new string('\\', backslash));
            }

            var stars = backslash;            
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dots), new string('*', stars));
                stars += 2;
                dots -= 1;
            }
        }
    }
}
