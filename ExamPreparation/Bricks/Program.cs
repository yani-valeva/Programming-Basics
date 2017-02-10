using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var cartCapacity = int.Parse(Console.ReadLine());

            var forCourse = (double)workers * cartCapacity;
            var courseNumbers = (double)Math.Ceiling(bricks / forCourse);

            Console.WriteLine(courseNumbers);
        }
    }
}
