using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var doctors = 7;
            var treated = 0;
            var untreated = 0;

            for (int i = 1; i <= period; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreated > treated)
                {
                    doctors++;
                }
                if (patients <= doctors)
                {
                    treated += patients;
                }
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
