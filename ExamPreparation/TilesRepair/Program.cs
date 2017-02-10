using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilesRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaSize = int.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileLength = double.Parse(Console.ReadLine());
            var benchWidth = int.Parse(Console.ReadLine());
            var benchLength = int.Parse(Console.ReadLine());

            var totalArea = (areaSize * areaSize) - (benchWidth * benchLength);
            var tileArea = tileWidth * tileLength;
            var tileNeeds = totalArea / tileArea;
            var timeNeeds = tileNeeds * 0.2;

            Console.WriteLine("{0}\n{1}", tileNeeds, timeNeeds);
        }
    }
}
