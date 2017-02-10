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
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var firstFigIn = (x >= 2 && x <= 12) && (y >= -3 && y <= 1);
            var secondFigIn = (x >= 4 && x <= 10) && (y >= -5 && y <= 3);

            if (firstFigIn || secondFigIn)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
