using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 0;
            var previousSum = 0.0;
            var currentSum = 0.0;
            double maxDiff = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                var firstNumber = double.Parse(Console.ReadLine());
                var secondNumber = double.Parse(Console.ReadLine());
                currentSum = firstNumber + secondNumber;
                if(previousSum == currentSum)
                {
                    counter++;
                }
                else
                {
                    var diff = Math.Abs(previousSum - currentSum);
                    if (maxDiff < diff)
                    {
                        if (i > 0)
                        {
                            maxDiff = diff;
                        }                       
                    }
                }
                previousSum = currentSum;
            }
            if (counter == n - 1)
            {
                Console.WriteLine("Yes, value={0}", currentSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
