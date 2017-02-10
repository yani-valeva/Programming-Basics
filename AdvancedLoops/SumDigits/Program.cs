using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sumDigit = 0;

            while (number > 0)
            {
                var digit = number % 10;
                sumDigit += digit;
                number = number / 10;
            }
            Console.WriteLine(sumDigit);
        }
    }
}
