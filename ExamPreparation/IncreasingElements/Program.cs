using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currentCounter = 1;
            var maxCounter = 1;

            if (n >= 1)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                var previousNumber = currentNumber;

                for (int i = 1; i < n; i++)
                {
                    currentNumber = int.Parse(Console.ReadLine());

                    if (previousNumber < currentNumber)
                    {
                        currentCounter++;
                    }
                    else
                    {
                        currentCounter = 1;
                    }
                    if (maxCounter < currentCounter)
                    {
                        maxCounter = currentCounter;
                    }
                    previousNumber = currentNumber;
                }
            }
            else
            {
                maxCounter = 0;
            }
            Console.WriteLine(maxCounter);
        }
    }
}
