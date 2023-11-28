using System;


namespace ReadReadKeyExampleApp;

class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a key: ");
        int key1 = Console.Read();
        Console.WriteLine($"ASCII value of the key is: {key1}");

        Console.WriteLine("=====================================================================");

        Console.Write("Enter another key: ");
        ConsoleKeyInfo key2 = Console.ReadKey();

        Console.WriteLine("You Entered:");
        Console.WriteLine($"Key: {key2.Key}");
        Console.WriteLine($"KeyChar: {key2.KeyChar}");
        Console.WriteLine($"ASCII code: {(int) key2.KeyChar}");

        Console.WriteLine("=====================================================================");

        Console.WriteLine("Enter any key to terminate...");
        Console.ReadKey();
    }
}