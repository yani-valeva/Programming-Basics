using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                var num = i;
                var num4 = num % 10;
                num = num / 10;
                var num3 = num % 10;
                num = num / 10;
                var num2 = num % 10;
                num = num / 10;
                var num1 = num % 10;

                if (num1 == 0 || num2 == 0 || num3 == 0 || num4 == 0)
                {
                    continue;
                }

                if ((n % num1 == 0) && (n % num2 == 0) && (n % num3 == 0) && (n % num4 == 0))
                {
                    Console.Write("{0}{1}{2}{3} ", num1, num2, num3, num4);
                }
            }
        }
    }
}
