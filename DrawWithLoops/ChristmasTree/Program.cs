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
            var spaces = n;
            var stars = 1;

            Console.WriteLine("{0} | {0}", new string(' ', spaces));
            spaces--;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}{1} | {1}{0}", new string(' ', spaces), new string('*', stars));
                spaces--;
                stars++;
            }
        }
    }
}
