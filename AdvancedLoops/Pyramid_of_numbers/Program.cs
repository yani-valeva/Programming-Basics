using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_of_numbers
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
                    if (number <= n)
                    {
                        Console.Write(number + " ");
                        number++;
                    }
                    else
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
