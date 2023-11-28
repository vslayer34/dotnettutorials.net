using System;


namespace BinaryLiteralExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        // Creating binary literals by prefixing with 0b
        int num1 = 0b100111101;
        int num2 = 0b01000011;
        // int num3 = 0b100134;                 // Error

        Console.WriteLine($"Value of num1 is: {num1}");
        Console.WriteLine($"Value of num2 is: {num2}");
        Console.WriteLine($"Char value of num1 is: {Convert.ToChar(num1)}");
        Console.WriteLine($"Char value of num2 is: {Convert.ToChar(num2)}");

        Console.ReadKey();
    }
}
