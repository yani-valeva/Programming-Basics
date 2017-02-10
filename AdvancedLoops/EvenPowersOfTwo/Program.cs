using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine(number);
                number *= 4;
            }
        }
    }
}
