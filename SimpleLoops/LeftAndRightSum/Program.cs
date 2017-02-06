using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                leftSum += currentNumber;
            }
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                rightSum += currentNumber;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                var diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
