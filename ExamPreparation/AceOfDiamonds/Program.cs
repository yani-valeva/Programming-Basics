using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfDiamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var monkey = 1;
            var dash = (n - (2 + monkey)) / 2;

            Console.WriteLine("{0}", new string('*', n));

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('-', dash), new string('@', monkey));
                dash -= 1;
                monkey += 2;
            }
            dash += 2;
            monkey -= 4;

            for (int i = n / 2; i > 1; i--)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('-', dash), new string('@', monkey));
                dash += 1;
                monkey -= 2;
            }

            Console.WriteLine("{0}", new string('*', n));
        }
    }
}
