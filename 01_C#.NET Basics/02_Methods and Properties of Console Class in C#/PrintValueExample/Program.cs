using System;


namespace PrintValueExample;

internal class Program
{
    private static void Main(String[] args)
    {
        string name = "Rana";

        Console.WriteLine(name);
        Console.WriteLine("Hello " + name);
        Console.WriteLine($"Best of mornings to you {name}");
        Console.ReadKey();
    }
}