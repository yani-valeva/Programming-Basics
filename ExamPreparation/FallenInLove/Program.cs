using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var waves = 0;
            var leftRightIn = 2 * n;
            var innerdots = 0;
            var leftRightOut = 1;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', waves), new string('.', leftRightIn), new string('.', innerdots));
                waves += 1;
                leftRightIn -= 2;
                innerdots += 2;
            }
            for (int row = 1; row <= n + 1; row++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', leftRightOut), new string('~', waves), new string('.', innerdots));
                leftRightOut += 2;
                waves -= 1;
                innerdots -= 2;
            }
            leftRightOut -= 1;
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}##{0}", new string('.', leftRightOut));
            }
        }
    }
}
