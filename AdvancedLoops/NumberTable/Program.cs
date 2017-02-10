using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                var increase = row;
                var decrease = n;
                for (int col = 1; col <= n; col++)
                {
                    if (increase < n)
                    {
                        Console.Write(increase + " ");
                        increase++;
                    }
                    else
                    {
                        Console.Write(decrease + " ");
                        decrease--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
