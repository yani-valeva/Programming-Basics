using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenSum);
            }
            else
            {
                var diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
        }
    }
}
