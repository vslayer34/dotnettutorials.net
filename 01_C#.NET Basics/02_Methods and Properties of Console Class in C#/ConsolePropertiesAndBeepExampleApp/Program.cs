using System;

namespace ConsolePropertiesAndBeepExampleApp;

class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Title = "Understanding Console Class";

        Console.WriteLine($"Background color: {ConsoleColor.Cyan.ToString()}");
        Console.WriteLine($"Foreground color: {ConsoleColor.Magenta.ToString()}");
        // Console.WriteLine($"Console Title: {Console.Title}");

        Console.Beep();

        Console.ReadKey();
    }
}