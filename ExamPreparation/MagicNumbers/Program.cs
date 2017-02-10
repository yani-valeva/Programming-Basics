using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 111111; i <= 999999; i++)
            {
                int num = i;
                int num6 = num % 10;
                num = num / 10;
                int num5 = num % 10;
                num = num / 10;
                int num4 = num % 10;
                num = num / 10;
                int num3 = num % 10;
                num = num / 10;
                int num2 = num % 10;
                num = num / 10;
                int num1 = num % 10;

                var result = num1 * num2 * num3 * num4 * num5 * num6;

                if (result == n)
                {
                    Console.Write("{0}{1}{2}{3}{4}{5} ", num1, num2, num3, num4, num5, num6);
                }
            }
        }
    }
}
