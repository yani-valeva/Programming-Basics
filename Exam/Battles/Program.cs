using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerPockemons = int.Parse(Console.ReadLine());
            var secondPlayerPockemons = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());

            var counter1 = 0;

            for (int num1 = 1; num1 <= firstPlayerPockemons; num1++)
            {
                for (int num2 = 1; num2 <= secondPlayerPockemons; num2++)
                {
                    counter1++;
                    if (counter1 <= battles)
                    {
                        Console.Write("({0} <-> {1}) ", num1, num2);
                    }
                    else
                    {
                        break;
                    }                
                }
            }
            Console.WriteLine();
        }
    }
}
