using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            var addBonusScore = 0.0;

            if (number <= 100)
            {
                bonusScore = 5;
            }
            else if (number <= 1000)
            {
                bonusScore = 0.2 * number;
            }
            else if (number > 1000)
            {
                bonusScore = 0.1 * number;
            }
            if (number % 2 == 0)
            {
                addBonusScore = 1;
            }
            if (number % 10 == 5)
            {
                addBonusScore = 2;
            }

            var totalBonusScore = bonusScore + addBonusScore;
            var numberWithBonus = number + totalBonusScore;

            Console.WriteLine(totalBonusScore);
            Console.WriteLine(numberWithBonus);
        }
    }
}
