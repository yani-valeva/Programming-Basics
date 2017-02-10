using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElection
{
    class Program
    {
        static void Main(string[] args)
        {
            var candidate = int.Parse(Console.ReadLine());
            var choice = int.Parse(Console.ReadLine());
            var symbol = Console.ReadLine().ToLower();

            var number = 1;

            Console.WriteLine("{0}", new string('.', 13));

            for (int i = 1; i <= candidate; i++)
            {
                if (i == choice && symbol == "x")
                {
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}|.\\./.|{0}", new string('.', 3));
                    Console.WriteLine("{0:00}.|..X..|{1}", number, new string('.', 3));
                    Console.WriteLine("{0}|./.\\.|{0}", new string('.', 3));
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}", new string('.', 13));
                    number++;
                }
                else if (i == choice && symbol == "v")
                {
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}|\\.../|{0}", new string('.', 3));
                    Console.WriteLine("{0:00}.|.\\./.|{1}", number, new string('.', 3));
                    Console.WriteLine("{0}|..V..|{0}", new string('.', 3));
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}", new string('.', 13));
                    number++;
                }
                else
                {
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
                    Console.WriteLine("{0:00}.|{1}|{2}", number, new string('.', 5), new string('.', 3));
                    Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}", new string('.', 13));
                    number++;
                }
            }
        }
    }
}
