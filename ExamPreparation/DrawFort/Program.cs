using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dash = (2 * n) - (((n / 2) * 2) + 4);
            var spaces = (2 * n) - (2 + dash);

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', dash));

            for (int row = 1; row <= n - 2; row++)
            {
                if (row == n - 2)
                {
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', spaces / 2), new string('_', dash));
                }
                else
                {
                    Console.WriteLine("|{0}|", new string(' ', (2 * n) - 2));
                }
            }

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', dash));
        }
    }
}
