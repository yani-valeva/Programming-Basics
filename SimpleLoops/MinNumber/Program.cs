using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
