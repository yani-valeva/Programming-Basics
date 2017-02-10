using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            if (operation == "+")
            {
                var sum = number1 + number2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", number1, number2, sum);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", number1, number2, sum);
                }
            }
            else if (operation == "-")
            {
                var diff = number1 - number2;
                if (diff % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", number1, number2, diff);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", number1, number2, diff);
                }
            }
            else if (operation == "*")
            {
                var multiply = number1 * number2;
                if (multiply % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", number1, number2, multiply);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", number1, number2, multiply);
                }
            }
            else if (operation == "/")
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    var division = Math.Round((double)number1 / number2, 2);
                    Console.WriteLine("{0} / {1} = {2:f2}", number1, number2, division);
                }
            }
            else if (operation == "%")
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    var remainder = number1 % number2;
                    Console.WriteLine("{0} % {1} = {2}", number1, number2, remainder);
                }
            }
        }
    }
}
