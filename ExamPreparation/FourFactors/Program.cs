using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            var FG = double.Parse(Console.ReadLine());
            var FGA = double.Parse(Console.ReadLine());
            var P = double.Parse(Console.ReadLine());
            var TOV = double.Parse(Console.ReadLine());
            var ORB = double.Parse(Console.ReadLine());
            var OppDRB = double.Parse(Console.ReadLine());
            var FT = double.Parse(Console.ReadLine());
            var FTA = double.Parse(Console.ReadLine());

            var eFGpercent = (FG + 0.5 * P) / FGA;
            var TOVpercent = TOV / (FGA + 0.44 * FTA + TOV);
            var ORBpercent = (double)ORB / (ORB + OppDRB);
            var FTpercent = (double)FT / FGA;

            Console.WriteLine("eFG% {0:f3}", eFGpercent);
            Console.WriteLine("TOV% {0:f3}", TOVpercent);
            Console.WriteLine("ORB% {0:f3}", ORBpercent);
            Console.WriteLine("FT% {0:f3}", FTpercent);
        }
    }
}
