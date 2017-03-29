using System;

class Styrofoam
{
    static void Main(string[] args)
    {
        var budget = double.Parse(Console.ReadLine());
        var houseArea = double.Parse(Console.ReadLine());
        var windowsNumber = int.Parse(Console.ReadLine());
        var styrofoamPerPackage = double.Parse(Console.ReadLine());
        var pricePerPackage = double.Parse(Console.ReadLine());

        var area = houseArea - (windowsNumber * 2.4);
        var totalArea = area + (10 / 100.0 * area);
        var neededPackages = Math.Ceiling(totalArea / styrofoamPerPackage);
        var totalPrice = neededPackages * pricePerPackage;
        var priceDifference = Math.Abs(budget - totalPrice);

        if (budget >= totalPrice)
        {
            Console.WriteLine($"Spent: {totalPrice:f2}");
            Console.WriteLine($"Left: {priceDifference:f2}");
        }
        else
        {
            Console.WriteLine($"Need more: {priceDifference:f2}");
        }
    }
}
