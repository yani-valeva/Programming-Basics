﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
            }

            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
            }
        }
    }
}
