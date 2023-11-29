using System;


namespace ExplicitConversionExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        double numberDouble = 1.23;

        // Explicit type casting
        int numberInt = (int) numberDouble;

        // Value before conversion
        Console.WriteLine($"Original double value: {numberDouble}");;

        // Value after conversion
        Console.WriteLine($"Value after conversion: {numberInt}");

        Console.WriteLine('\n' + "======================================================================" + '\n');

        int intNum1 = 100;
        byte byteNum1 = (byte) intNum1;                     // Explicit type casting
        // Printing the original value and the converted value
        Console.WriteLine($"Original Value: {intNum1}".PadRight(15) + $"Converted Value: {byteNum1}");

        int intNum2 = 500;
        byte byteNum2 = (byte) intNum2;                     // Explicit type casting
        // Printing the original and converted value
        Console.WriteLine($"Original Value: {intNum2}".PadRight(15) + $"Converted Value: {byteNum2}");

        Console.ReadKey();
    }
}
