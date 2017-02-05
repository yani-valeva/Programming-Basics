using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();
            var BGN = 0.0;
            var EUR = 0.0;
            var GBP = 0.0;
            var USD = 0.0;

            if (inputCurrency == "USD")
            {
                USD = money;
                BGN = money * 1.79549;
                EUR = BGN / 1.95583;
                GBP = BGN / 2.53405;                
            }
           else if (inputCurrency == "BGN")
           {
                BGN = money;
                USD = money / 1.79549;
                EUR = money / 1.95583;
                GBP = money / 2.53405;
           }
           else if (inputCurrency == "EUR")
           {
                EUR = money;
                BGN = money * 1.95583;
                USD = BGN / 1.79549;
                GBP = BGN / 2.53405;               
           }
           else if (inputCurrency == "GBP")
           {
                GBP = money;
                BGN = money * 2.53405;
                USD = BGN / 1.79549;
                EUR = BGN / 1.95583;                
           }
           if(outputCurrency == "BGN")
           {
                Console.WriteLine("{0} BGN", Math.Round(BGN, 2));
           }
           else if (outputCurrency == "USD")
           {
                Console.WriteLine("{0} USD", Math.Round(USD, 2));
           }
           else if (outputCurrency == "EUR")
           {
                Console.WriteLine("{0} EUR", Math.Round(EUR, 2));
           }
           else if (outputCurrency == "GBP")
           {
                Console.WriteLine("{0} GBP", Math.Round(GBP, 2));
           }
        }
    }
}
