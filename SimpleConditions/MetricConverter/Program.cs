using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();
            var meters = 0.0;
            var millimeters = 0.0;
            var centimeters = 0.0;
            var miles = 0.0;
            var inches = 0.0;
            var kilometers = 0.0;
            var feet = 0.0;
            var yards = 0.0;

            if (inputMetric == "m")
            {
                meters = number;
                millimeters = number * 1000;
                centimeters = number * 100;
                miles = number * 0.000621371192;
                inches = number * 39.3700787;
                kilometers = number * 0.001;
                feet = number * 3.2808399;
                yards = number * 1.0936133;
            }
            else if (inputMetric == "mm")
            {
                millimeters = number;
                meters = number / 1000;               
                centimeters = meters * 100;
                miles = meters * 0.000621371192;
                inches = meters * 39.3700787;
                kilometers = meters * 0.001;
                feet = meters * 3.2808399;
                yards = meters * 1.0936133;
            }
            else if (inputMetric == "cm")
            {
                centimeters = number;
                meters = number / 100;
                millimeters = meters * 1000;
                miles = meters * 0.000621371192;
                inches = meters * 39.3700787;
                kilometers = meters * 0.001;
                feet = meters * 3.2808399;
                yards = meters * 1.0936133;
            }
            else if (inputMetric == "mi")
            {
                miles = number;
                meters = number / 0.000621371192;
                millimeters = meters * 1000;
                centimeters = meters * 100;
                inches = meters * 39.3700787;
                kilometers = meters * 0.001;
                feet = meters * 3.2808399;
                yards = meters * 1.0936133;
            }
            else if (inputMetric == "in")
            {
                inches = number;
                meters = number / 39.3700787;
                millimeters = meters * 1000;
                centimeters = meters * 100;
                miles = meters * 0.000621371192;
                kilometers = meters * 0.001;
                feet = meters * 3.2808399;
                yards = meters * 1.0936133;
            }
            else if (inputMetric == "km")
            {
                kilometers = number;
                meters = number / 0.001;
                millimeters = meters * 1000;
                centimeters = meters * 100;
                miles = meters * 0.000621371192;
                inches = meters * 39.3700787;
                feet = meters * 3.2808399;
                yards = meters * 1.0936133;
            }
            else if (inputMetric == "ft")
            {
                feet = number;
                meters = number / 3.2808399;
                millimeters = meters * 1000;
                centimeters = meters * 100;
                miles = meters * 0.000621371192;
                inches = meters * 39.3700787;
                kilometers = meters * 0.001;
                yards = meters * 1.0936133;
            }
            else if (inputMetric == "yd")
            {
                yards = number;
                meters = number / 1.0936133;
                millimeters = meters * 1000;
                centimeters = meters * 100;
                miles = meters * 0.000621371192;
                inches = meters * 39.3700787;
                kilometers = meters * 0.001;
                feet = meters * 3.2808399;
            }
            if (outputMetric == "m")
            {
                Console.WriteLine("{0} m", meters);
            }
            else if (outputMetric == "mm")
            {
                Console.WriteLine("{0} mm", millimeters);
            }
            else if (outputMetric == "cm")
            {
                Console.WriteLine("{0} cm", centimeters);
            }
            else if (outputMetric == "mi")
            {
                Console.WriteLine("{0} mi", miles);
            }
            else if (outputMetric == "in")
            {
                Console.WriteLine("{0} in", inches);
            }
            else if (outputMetric == "km")
            {
                Console.WriteLine("{0} km", kilometers);
            }
            else if (outputMetric == "ft")
            {
                Console.WriteLine("{0} ft", feet);
            }
            else if (outputMetric == "yd")
            {
                Console.WriteLine("{0} yd", yards);
            }
        }
    }
}
