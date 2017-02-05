using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSportsman = int.Parse(Console.ReadLine());
            var secondSportsman = int.Parse(Console.ReadLine());
            var thirdSportsman = int.Parse(Console.ReadLine());

            var sumSeconds = firstSportsman + secondSportsman + thirdSportsman;           
            var minutes = sumSeconds / 60;
            var seconds = sumSeconds % 60;

            Console.WriteLine("{0}:{1:00}", minutes, seconds);   
        }
    }
}
