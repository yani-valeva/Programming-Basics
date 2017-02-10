using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;

            if (n % 2 == 0)
            {
                stars = 2;
            }
            var dashes = (n - stars) / 2;

            if (n % 2 != 0)
            {
                for (int row = 1; row <= (n / 2) + 1; row++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
                    dashes -= 1;
                    stars += 2;
                }
            }
            else if (n % 2 == 0)
            {
                for (int row = 1; row <= n / 2; row++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
                    dashes -= 1;
                    stars += 2;
                }
            }
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
