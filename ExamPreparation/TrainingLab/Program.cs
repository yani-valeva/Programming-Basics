using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var hallWidth = (h * 100) - 100;
            var desksInRow = Math.Floor(hallWidth / 70);
            var hallLength = w * 100;
            var rows = Math.Floor(hallLength / 120);
            var placesNumbers = (rows * desksInRow) - 3;

            Console.WriteLine(placesNumbers);
        }
    }
}
