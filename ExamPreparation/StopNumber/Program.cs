using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());

            for (int i = secondNumber; i >= firstNumber; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i != stopNumber)
                    {
                        Console.Write("{0} ", i);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
