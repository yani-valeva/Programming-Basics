using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var apartmentPrice = 0.0;
            var studioPrice = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    studioPrice = 50 - (0.05 * 50);
                    apartmentPrice = 65;
                }
                else if (nights > 14)
                {
                    studioPrice = 50 - (0.3 * 50);
                    apartmentPrice = 65 - (0.1 * 65);
                }
                else
                {
                    studioPrice = 50;
                    apartmentPrice = 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    studioPrice = 75.20 - (0.2 * 75.20);
                    apartmentPrice = 68.70 - (0.1 * 68.70);
                }
                else
                {
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    apartmentPrice = 77 - (0.1 * 77);
                }
                else
                {
                    apartmentPrice = 77;
                }
                studioPrice = 76;
            }

            Console.WriteLine("Apartment: {0:f2} lv.", nights * apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", nights * studioPrice);
        }
    }
}
