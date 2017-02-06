using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var filmShow = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            var totalPrice = 0.0;

            if (filmShow == "Premiere")
            {
                totalPrice = rows * columns * 12.00;
            }
            else if (filmShow == "Normal")
            {
                totalPrice = rows * columns * 7.50;
            }
            else if (filmShow == "Discount")
            {
                totalPrice = rows * columns * 5.00;
            }
            Console.WriteLine("{0:f2} leva", totalPrice);
        }        
    }
}
