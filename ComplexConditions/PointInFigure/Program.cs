using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var x1 = 0;
            var y1 = 0;
            var x2 = 3 * h;
            var y2 = h;
            var a1 = h;
            var b1 = 0;
            var a2 = 2 * h;
            var b2 = 4 * h;
            var onFirstFigBorder = ((x == x1 || x == x2) && (y >= y1 && y <= y2)) || ((y == y1 || y == y2) && (x >= x1 && x <= x2));
            var onSecondFigBorder = ((x == a1 || x == a2) && (y >= b1 && y <= b2)) || ((y == b1 || y == b2) && (x >= a1 && x <= a2));
            var firstFigInside = (x > x1 && x < x2) && (y > y1 && y < y2);
            var secondFigInside = (x > a1 && x < a2) && (y > b1 && y < b2);

            if (firstFigInside || secondFigInside)
            {
                Console.WriteLine("inside");
            }
            else if (onFirstFigBorder || onSecondFigBorder)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
