using System;


namespace DecimalNumericExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        // Single a = 1.123f;
        float a = 1.123f;

        // Double b = 1.456;
        double b = 1.456f;

        // Decimal c = 1.789m;
        decimal c = 1.789m;

        Console.WriteLine($"float/Single Min Value: {float.MinValue}".PadRight(100) + $"float/Single Max Value: {float.MaxValue}");
        Console.WriteLine($"float/Single Size: {sizeof(float)}");
        Console.WriteLine();

        Console.WriteLine($"double/Double Min Value: {double.MinValue}".PadRight(100) + $"double/Double Max Value: {double.MaxValue}");
        Console.WriteLine($"double/Double Size: {sizeof(double)}");
        Console.WriteLine();

        Console.WriteLine($"decimal/Decimal Min Value: {decimal.MinValue}".PadRight(100) + $"decimal/Decimal Max Value: {decimal.MaxValue}");
        Console.WriteLine($"decimal/Decimal Size: {sizeof(decimal)}");
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(new string('-', 100));
        Console.WriteLine();

        Console.WriteLine("Percision");
        Console.WriteLine("=========");

        float x = 1.78986380830029492956829698978655434342477f;             // max 7 percision digits
        double y = 1.78986380830029492956829698978655434342477;             // max 15 percision digits
        decimal z = 1.78986380830029492956829698978655434342477m;           // max 29 percision digits


        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

        Console.ReadKey();
    }
}