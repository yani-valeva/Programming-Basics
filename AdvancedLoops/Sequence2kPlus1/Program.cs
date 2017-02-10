using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;

            while (number <= n)
            {
                Console.WriteLine(number);
                number = number * 2 + 1;
            }
        }
    }
}
