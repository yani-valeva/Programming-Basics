using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var hut = 1;
            var dots = n;

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', dots), new string('^', hut));
                dots -= 1;
                hut += 2;
            }
            dots = n - 1;
            hut = 3;

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', dots), new string('^', hut));
                dots -= 1;
                hut += 2;
            }

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.WriteLine("{0}| |{0}", new string('\'', n - 1));
            }

            Console.WriteLine("{0}", new string('-', (2 * n) + 1));
        }
    }
}
