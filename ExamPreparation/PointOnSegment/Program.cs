using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var min = Math.Min(first, second);
            var max = Math.Max(first, second);
            var diff1 = Math.Abs(min - point);
            var diff2 = Math.Abs(max - point);
            var smallerDiff = Math.Min(diff1, diff2);

            if (point >= min && point <= max)
            {
                Console.WriteLine("in");
                Console.WriteLine(smallerDiff);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(smallerDiff);
            }
        }
    }
}
