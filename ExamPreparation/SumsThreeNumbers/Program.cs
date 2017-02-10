using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var maxNumber = 0;
            var minNumber = 0;

            if (firstNumber + secondNumber == thirdNumber)
            {
                maxNumber = Math.Max(firstNumber, secondNumber);
                minNumber = Math.Min(firstNumber, secondNumber);
                Console.WriteLine("{0} + {1} = {2}", minNumber, maxNumber, thirdNumber);
            }
            else if (secondNumber + thirdNumber == firstNumber)
            {
                maxNumber = Math.Max(secondNumber, thirdNumber);
                minNumber = Math.Min(secondNumber, thirdNumber);
                Console.WriteLine("{0} + {1} = {2}", minNumber, maxNumber, firstNumber);
            }
            else if (firstNumber + thirdNumber == secondNumber)
            {
                maxNumber = Math.Max(firstNumber, thirdNumber);
                minNumber = Math.Min(firstNumber, thirdNumber);
                Console.WriteLine("{0} + {1} = {2}", minNumber, maxNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
