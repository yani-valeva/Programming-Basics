using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            var dashes = (n - stars) / 2;
            var middleDashes = stars;

            if (n >= 3)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));

                dashes -= 1;

                for (int row = 1; row <= (n - 1) / 2; row++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', dashes), new string('-', middleDashes));
                    dashes -= 1;
                    middleDashes += 2;
                }
                dashes += 2;
                middleDashes -= 4;
                for (int row = (n - 1) / 2; row > 1; row--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', dashes), new string('-', middleDashes));
                    dashes += 1;
                    middleDashes -= 2;
                }
                Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
            }
            else
            {
                Console.WriteLine("{0}", new string('*', stars));
            }           
        }
    }
}
