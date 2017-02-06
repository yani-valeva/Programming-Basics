using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());           
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var previousSum = firstNumber + secondNumber;
            var currentSum = 0.0;
            var counter = 0;
            double maxDiff = double.MinValue;

            for (int i = 0; i < n - 1; i++)
            {
                firstNumber = double.Parse(Console.ReadLine());
                secondNumber = double.Parse(Console.ReadLine());
                currentSum = firstNumber + secondNumber;
                if (previousSum == currentSum)
                {
                    counter++;
                }
                else
                {
                    var diff = Math.Abs(previousSum - currentSum);
                    if (maxDiff < diff)
                    {
                        maxDiff = diff;
                    }
                }
                previousSum = currentSum;
            }
            if (counter == n - 1)
            {
                Console.WriteLine("Yes, value={0}", previousSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }        
        }
    }
}
