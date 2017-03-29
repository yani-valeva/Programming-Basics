using System;

class TruckDriver
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        var kilometersPerMonth = double.Parse(Console.ReadLine());
        var salary = 0.0;

        if (kilometersPerMonth > 10000)
        {
            salary += kilometersPerMonth * 1.45 * 4;
        }
        else
        {
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kilometersPerMonth <= 5000)
                    {
                        salary += kilometersPerMonth * 0.75 * 4;
                    }
                    else if (kilometersPerMonth <= 10000)
                    {
                        salary += kilometersPerMonth * 0.95 * 4;
                    }
                    break;
                case "Summer":
                    if (kilometersPerMonth <= 5000)
                    {
                        salary += kilometersPerMonth * 0.90 * 4;
                    }
                    else if (kilometersPerMonth <= 10000)
                    {
                        salary += kilometersPerMonth * 1.10 * 4;
                    }
                    break;
                case "Winter":
                    if (kilometersPerMonth <= 5000)
                    {
                        salary += kilometersPerMonth * 1.05 * 4;
                    }
                    else if (kilometersPerMonth <= 10000)
                    {
                        salary += kilometersPerMonth * 1.25 * 4;
                    }
                    break;
            }            
        }
        salary -= (0.1 * salary);
        Console.WriteLine($"{salary:f2}");
    }
}
