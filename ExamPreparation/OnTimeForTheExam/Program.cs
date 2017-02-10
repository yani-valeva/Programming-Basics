using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());

            var examTime = (examHour * 60) + examMinute;
            var arrivalTime = (arrivalHour * 60) + arrivalMinute;
            var resultTime = Math.Abs(examTime - arrivalTime);
            var hours = 0;
            var minutes = 0;

            if (examTime < arrivalTime)
            {
                Console.WriteLine("Late");
                if (resultTime < 60)
                {
                    Console.WriteLine("{0} minutes after the start", resultTime);
                }
                else if (resultTime >= 60)
                {
                    hours = resultTime / 60;
                    minutes = resultTime % 60;
                    Console.WriteLine("{0}:{1:00} hours after the start", hours, minutes);
                }
            }
            else if (examTime == arrivalTime)
            {
                Console.WriteLine("On time");
            }
            else
            {
                if (resultTime <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", resultTime);
                }
                else if (resultTime > 30 && resultTime < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", resultTime);
                }
                else
                {
                    Console.WriteLine("Early");
                    hours = resultTime / 60;
                    minutes = resultTime % 60;
                    Console.WriteLine("{0}:{1:00} hours before the start", hours, minutes);
                }
            }
        }
    }
}
