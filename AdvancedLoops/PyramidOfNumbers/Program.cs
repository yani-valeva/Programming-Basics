using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {

                    Console.Write(number);
                    Console.Write(" ");
                    number++;
                    if (number > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (number > n)
                {
                    break;
                }
            }
        }
    }
}
