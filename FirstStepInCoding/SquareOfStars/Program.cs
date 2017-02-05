using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.WriteLine("{0}", new string('*', n));
                }
                else
                {
                    Console.WriteLine("*{0}*", new string(' ', n - 2));
                }
            }
        }
    }
}
