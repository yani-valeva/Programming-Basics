using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var spaces = n - 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write("{0}*", new string(' ', spaces));
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                spaces--;
            }
            spaces += 2;
            for (int row = n - 1; row >= 1; row--)
            {
                Console.Write("{0}*", new string(' ', spaces));
                for (int col = row - 1; col >= 1; col--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                spaces++;
            }
        }
    }
}
