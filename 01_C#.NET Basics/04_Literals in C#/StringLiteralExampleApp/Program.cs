using System;


namespace StringLiteralExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        string str1 = "Dot Net Tutorials";
        string str2 = @"Dot Net Tutorials";

        string str3 = "Dot\nNet\tTutorials";
        string str4 = @"Dot\nNet\tTutorials";

        Console.WriteLine($"str1: {str1}");
        Console.WriteLine($"str2: {str2}");
        Console.WriteLine($"str3: {str3}");
        Console.WriteLine($"str4: {str4}");

        Console.ReadKey();
    }
}
