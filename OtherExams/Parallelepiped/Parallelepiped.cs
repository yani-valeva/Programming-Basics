using System;

class Parallelepiped
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var tilde = n - 2;
        var dots = (2 * n) + 1;
        var innerDots = 0;

        Console.WriteLine("+{0}+{1}", new string('~', tilde), new string('.', dots));
        dots--;

        for (int row = 1; row <= (2 * n) + 1; row++)
        {
            Console.WriteLine("|{0}\\{1}\\{2}", new string('.', innerDots), new string('~', tilde), new string('.', dots));
            innerDots++;
            dots--;
        }

        dots++;
        innerDots--;

        for (int row = 1; row <= (2 * n) + 1; row++)
        {
            Console.WriteLine("{0}\\{1}|{2}|", new string('.', dots), new string('.', innerDots), new string('~', tilde));
            dots++;
            innerDots--;
        }

        Console.WriteLine("{0}+{1}+", new string('.', dots), new string('~', tilde));
    }
}
