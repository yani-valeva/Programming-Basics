using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatiLock
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftRightOut = n - 2;
            var innerDots = n - 2;
            var leftRightIn = 0;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', leftRightOut), new string('.', leftRightIn), new string('.', innerDots));
                leftRightIn += 2;
                leftRightOut -= 2;
            }
            leftRightIn -= 2;
            leftRightOut += 2;

            for (int row = n / 2; row >= 1; row--)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', leftRightOut), new string('.', leftRightIn), new string('.', innerDots));
                leftRightIn -= 2;
                leftRightOut += 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}
