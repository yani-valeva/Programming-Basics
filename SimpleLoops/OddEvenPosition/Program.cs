using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                    if (evenMin > currentNumber)
                    {
                        evenMin = currentNumber;
                    }
                    if (evenMax < currentNumber)
                    {
                        evenMax = currentNumber;
                    }
                }
                else
                {
                    oddSum += currentNumber;
                    if (oddMin > currentNumber)
                    {
                        oddMin = currentNumber;
                    }
                    if (oddMax < currentNumber)
                    {
                        oddMax = currentNumber;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum={0},", oddSum);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0},", evenSum);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum={0},", oddSum);
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);
                Console.WriteLine("EvenSum={0},", evenSum);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("OddSum={0},", oddSum);
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);
                Console.WriteLine("EvenSum={0},", evenSum);
                Console.WriteLine("EvenMin={0},", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }           
        }
    }
}
