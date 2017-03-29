using System;

class CheckNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int checkNumber = int.Parse(Console.ReadLine());
        int sum = 0;
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = m; j >= 1; j--)
            {
                sum += (i * 2) + (j * 3);
                count++;

                if (sum >= checkNumber)
                {
                    Console.WriteLine($"{count} moves");
                    Console.WriteLine($"Score: {sum} >= {checkNumber}");
                    return;
                }
            }
        }

        Console.WriteLine($"{count} moves");
    }
}

