using System;

class MonthlyExpenses
{
    static void Main(string[] args)
    {
        var months = int.Parse(Console.ReadLine());
        var electricityBill = 0.0;
        var otherExpenses = 0.0;

        for (int i = 0; i < months; i++)
        {
            var currentElectricity = double.Parse(Console.ReadLine());
            var otherCurrentExpenses = (currentElectricity + 20 + 15) + (0.2 * (currentElectricity + 20 + 15));
            electricityBill += currentElectricity;
            otherExpenses += otherCurrentExpenses;
        }

        var waterBill = months * 20.0;
        var internetBill = months * 15.0;
        var average = (electricityBill + waterBill + internetBill + otherExpenses) / months;

        Console.WriteLine($"Electricity: {electricityBill:f2} lv");
        Console.WriteLine($"Water: {waterBill:f2} lv");
        Console.WriteLine($"Internet: {internetBill:f2} lv");
        Console.WriteLine($"Other: {otherExpenses:f2} lv");
        Console.WriteLine($"Average: {average:f2} lv");
    }
}
