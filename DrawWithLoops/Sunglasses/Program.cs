using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());            

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));

            for (int row = 1; row <= n - 2; row++)
            {
                if (n % 2 != 0 && row == n / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * n) - 2), new string('|', n));
                }
                else if (n % 2 == 0 && row == (n / 2) - 1)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * n) - 2), new string('|', n));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * n) - 2), new string(' ', n));
                }                
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}
