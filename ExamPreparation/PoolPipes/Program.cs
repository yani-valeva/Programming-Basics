using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var poolVolume = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var totalWater = (pipe1 * hours) + (pipe2 * hours);

            if (totalWater <= poolVolume)
            {
                var totalPercentWater = (totalWater / poolVolume) * 100;
                var pipe1Percent = ((pipe1 * hours) / totalWater) * 100;
                var pipe2Percent = ((pipe2 * hours) / totalWater) * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(totalPercentWater), Math.Truncate(pipe1Percent), Math.Truncate(pipe2Percent));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, totalWater - poolVolume);
            }
        }
    }
}
