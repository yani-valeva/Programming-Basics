using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2k_Plus1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;

            for (int i = 0; i <= n; i++)
            {
                if (number > n)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(number);
                    number = number * 2 + 1;
                }
            }
        }
    }
}
