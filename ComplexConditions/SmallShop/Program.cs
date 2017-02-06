using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {           
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var totalPrice = 0.0;

            switch (town)
            {
                case "sofia":
                    if(product == "coffee")
                    {
                        totalPrice = quantity * 0.50;
                    }
                    else if (product == "water")
                    {
                        totalPrice = quantity * 0.80;
                    }
                    else if (product == "beer")
                    {
                        totalPrice = quantity * 1.20;
                    }
                    else if (product == "sweets")
                    {
                        totalPrice = quantity * 1.45;

                    }
                    else if (product == "peanuts")
                    {
                        totalPrice = quantity * 1.60;

                    }
                    break;

                case "plovdiv":
                    if (product == "coffee")
                    {
                        totalPrice = quantity * 0.40;
                    }
                    else if (product == "water")
                    {
                        totalPrice = quantity * 0.70;
                    }
                    else if (product == "beer")
                    {
                        totalPrice = quantity * 1.15;
                    }
                    else if (product == "sweets")
                    {
                        totalPrice = quantity * 1.30;

                    }
                    else if (product == "peanuts")
                    {
                        totalPrice = quantity * 1.50;

                    }
                    break;

                case "varna":
                    if (product == "coffee")
                    {
                        totalPrice = quantity * 0.45;
                    }
                    else if (product == "water")
                    {
                        totalPrice = quantity * 0.70;
                    }
                    else if (product == "beer")
                    {
                        totalPrice = quantity * 1.10;
                    }
                    else if (product == "sweets")
                    {
                        totalPrice = quantity * 1.35;

                    }
                    else if (product == "peanuts")
                    {
                        totalPrice = quantity * 1.55;

                    }
                    break;
            }
            Console.WriteLine(totalPrice);
        }
    }
}
