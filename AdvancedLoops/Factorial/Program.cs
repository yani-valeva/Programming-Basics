using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var factorial = 1;

            while (n > 1)
            {
                factorial = factorial * n;
                n--;
            }
            Console.WriteLine(factorial);
        }
    }
}
