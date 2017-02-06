using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var comission = -1.0;

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.05 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.07 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.08 * sales;
                }
                else if (sales > 10000)
                {
                    comission = 0.12 * sales;
                }               
            }
            if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.075 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.1 * sales;
                }
                else if (sales > 10000)
                {
                    comission = 0.13 * sales;
                }
            }
            if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.08 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.12 * sales;
                }
                else if (sales > 10000)
                {
                    comission = 0.145 * sales;
                }
            }
            if (comission < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", comission);
            }
        }
    }
}
