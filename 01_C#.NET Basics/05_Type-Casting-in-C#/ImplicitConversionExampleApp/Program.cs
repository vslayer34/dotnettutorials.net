using System;


namespace ImplicitConversionExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        int intNumber = 1500;

        // Get type of intNumber
        Type intNumberType = intNumber.GetType();

        // Impilicit Conversion
        double doubleNumber = intNumber;

        // Get type of doubleNumber
        Type doubleNumberType = doubleNumber.GetType();

        Console.WriteLine("Value before conversion");
        Console.WriteLine($"intNumber Value: {intNumber}");
        Console.WriteLine($"intNumber Type: {intNumberType}");
        Console.WriteLine($"int Size: {sizeof(int)} bytes");

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Value before conversion");
        Console.WriteLine($"doubleNumber Value: {doubleNumber}");
        Console.WriteLine($"doubleNumber Type: {doubleNumberType}");
        Console.WriteLine($"double Size: {sizeof(double)} bytes");

        Console.ReadKey();
    }
}
