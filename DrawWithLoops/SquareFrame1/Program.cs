using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame1
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
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }
                for (int col = 1; col < n; col++)
                {
                    if (col == n - 1 && (row == 1 || row == n))
                    {
                        Console.Write(" +");
                    }
                    else if (col == n - 1)
                    {
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
