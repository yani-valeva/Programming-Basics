using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", new string('%', 2 * n));

            if (n % 2 == 0)
            {
                for (int row = 1; row < n; row++)
                {
                    if (row == n / 2)
                    {
                        Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', (2 * n) - 2));
                    }
                }
            }
            else
            {
                for (int row = 1; row <= n; row++)
                {
                    if (row == (n + 1) / 2)
                    {
                        Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', (2 * n) - 2));
                    }
                }
            }
            Console.WriteLine("{0}", new string('%', 2 * n));
        }
    }
}
