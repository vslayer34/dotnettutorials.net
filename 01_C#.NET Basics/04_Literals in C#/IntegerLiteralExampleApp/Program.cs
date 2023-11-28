using System;


namespace IntegerLiteralExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        // Decimal allowed digits: 0 to 9
        int a = 101;                // no suffix is needed

        // Hexa-Decimal Literals
        // Allowed digits: 0 to 9 and characters a to f
        int b = 0x123f;             // prefix with 0x and suffix with f

        // binary Literals
        // Allowed digits: 0, 1
        int c = 0b1111;             // prefix with 0b

        Console.WriteLine($"Decimal Literal: {a}");
        Console.WriteLine($"Hexa-Decimal Literal: {b}");
        Console.WriteLine($"Binary Literal: {c}");


        int aa = 1000;              // Integer
        uint bb = 1000u;            // unsighned integer
        long cc = 1000l;            // Long
        ulong dd = 1000ul;          // unsigned long

        Console.WriteLine($"Integer Literal: {aa}");
        Console.WriteLine($"Unsigned Integer Literal: {bb}");
        Console.WriteLine($"Long Literal: {cc}");
        Console.WriteLine($"Unsigned Long Literal: {dd}");

        Console.ReadKey();
    }
}