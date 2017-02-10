using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holidays
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var transportPrice = 0.0;
            var nightsPrice = 0.0;
            var commission = 0.0;
            var totalPrice = 0.0;

            if (transport == "train")
            {
                if (adults + students >= 50)
                {
                    transportPrice = ((adults * 24.99) + (students * 14.99)) * 2;
                    transportPrice = transportPrice - (transportPrice * 0.50);
                    nightsPrice = nights * 82.99;
                    commission = (transportPrice + nightsPrice) * 0.10;
                    totalPrice = transportPrice + nightsPrice + commission;
                }
                else
                {
                    transportPrice = ((adults * 24.99) + (students * 14.99)) * 2;
                    nightsPrice = nights * 82.99;
                    commission = (transportPrice + nightsPrice) * 0.10;
                    totalPrice = transportPrice + nightsPrice + commission;
                }
            }
            else if (transport == "bus")
            {
                transportPrice = ((adults * 32.50) + (students * 28.50)) * 2;
                nightsPrice = nights * 82.99;
                commission = (transportPrice + nightsPrice) * 0.10;
                totalPrice = transportPrice + nightsPrice + commission;
            }
            else if (transport == "boat")
            {
                transportPrice = ((adults * 42.99) + (students * 39.99)) * 2;
                nightsPrice = nights * 82.99;
                commission = (transportPrice + nightsPrice) * 0.10;
                totalPrice = transportPrice + nightsPrice + commission;
            }
            else if (transport == "airplane")
            {
                transportPrice = ((adults * 70.00) + (students * 50.00)) * 2;
                nightsPrice = nights * 82.99;
                commission = (transportPrice + nightsPrice) * 0.10;
                totalPrice = transportPrice + nightsPrice + commission;
            }
            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
