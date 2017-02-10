using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var thirdDigit = n % 10;
            var newN = n / 10;
            var secondDigit = newN % 10;
            newN = newN / 10;
            var firstDigit = newN % 10;

            for (int row = 1; row <= firstDigit + secondDigit; row++)
            {
                for (int col = 1; col <= firstDigit + thirdDigit; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                    }
                    else
                    {
                        n += thirdDigit;
                    }
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }
    }
}
