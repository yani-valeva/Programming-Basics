using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFrom0To100Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var firstNumber = number / 10;
            var secondNumber = number % 10;
            var bothNumber = number;

            string firstWord = "";
            string secondWord = "";
            string bothWord = "";

            switch (secondNumber)
            {
                case 0:
                    secondWord = "zero";
                    break;
                case 1:
                    secondWord = "one";
                    break;
                case 2:
                    secondWord = "two";
                    break;
                case 3:
                    secondWord = "three";
                    break;
                case 4:
                    secondWord = "four";
                    break;
                case 5:
                    secondWord = "five";
                    break;
                case 6:
                    secondWord = "six";
                    break;
                case 7:
                    secondWord = "seven";
                    break;
                case 8:
                    secondWord = "eight";
                    break;
                case 9:
                    secondWord = "nine";
                    break;
            }
            switch (firstNumber)
            {
                case 2:
                    firstWord = "twenty";
                    break;
                case 3:
                    firstWord = "thirty";
                    break;
                case 4:
                    firstWord = "forty";
                    break;
                case 5:
                    firstWord = "fifty";
                    break;
                case 6:
                    firstWord = "sixty";
                    break;
                case 7:
                    firstWord = "seventy";
                    break;
                case 8:
                    firstWord = "eighty";
                    break;
                case 9:
                    firstWord = "ninety";
                    break;
            }
            switch (bothNumber)
            {
                case 10:
                    bothWord = "ten";
                    break;
                case 11:
                    bothWord = "eleven";
                    break;
                case 12:
                    bothWord = "twelve";
                    break;
                case 13:
                    bothWord = "thirteen";
                    break;
                case 14:
                    bothWord = "fourteen";
                    break;
                case 15:
                    bothWord = "fifteen";
                    break;
                case 16:
                    bothWord = "sixteen";
                    break;
                case 17:
                    bothWord = "seventeen";
                    break;
                case 18:
                    bothWord = "eighteen";
                    break;
                case 19:
                    bothWord = "nineteen";
                    break;
            }
            if (number >= 0 && number <= 9)
            {
                Console.WriteLine(secondWord);
            }
            else if (number >= 10 && number <= 19)
            {
                Console.WriteLine(bothWord);
            }
            else if (number >= 20 && number <= 100)
            {
                if (number % 10 == 0 && number != 100)
                {
                    Console.WriteLine(firstWord);
                }
                else if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else
                {
                    Console.WriteLine("{0} {1}", firstWord, secondWord);
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
