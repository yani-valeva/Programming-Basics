﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int left = -n; left < n; left++)
            {
                for (int right = left + 1; right <= n; right++)
                {
                    for (int top = -n; top < n; top++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            var a = right - left;
                            var b = bottom - top;
                            var area = a * b;


                            if (area >= m)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                counter++;
                            }

                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
