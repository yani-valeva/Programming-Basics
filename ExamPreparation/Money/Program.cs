using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yuans = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var bitcoinToLeva = bitcoins * 1168;
            var yuanToLeva = yuans * 0.15 * 1.76;
            var leva = bitcoinToLeva + yuanToLeva;
            var levaToEuro = leva / 1.95;
            var commisionSize = (commission / 100) * levaToEuro;
            var totalInEuro = levaToEuro - commisionSize;

            Console.WriteLine(totalInEuro);
        }
    }
}
