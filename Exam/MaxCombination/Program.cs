using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var MaxCombination = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    if (MaxCombination >= counter)
                    {
                        Console.Write("<{0}-{1}>", num1, num2);
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
