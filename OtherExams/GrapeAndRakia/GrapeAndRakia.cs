using System;

class GrapeAndRakia
{
    static void Main(string[] args)
    {
        var vineyardArea = double.Parse(Console.ReadLine());
        var grapePerSquareMeter = double.Parse(Console.ReadLine());
        var wasteGrape = double.Parse(Console.ReadLine());
        var grapeKg = vineyardArea * grapePerSquareMeter;
        var totalGrapeKg = grapeKg - wasteGrape;
        var grapeForAlcohol = 45 / 100.0 * totalGrapeKg;
        var litersAlcohol = grapeForAlcohol / 7.5;
        var alcoholProfit = litersAlcohol * 9.80;
        var grapeForSale = 55 / 100.0 * totalGrapeKg;
        var grapeProfit = grapeForSale * 1.50;

        Console.WriteLine($"{alcoholProfit:f2}");
        Console.WriteLine($"{grapeProfit:f2}");
    }
}
