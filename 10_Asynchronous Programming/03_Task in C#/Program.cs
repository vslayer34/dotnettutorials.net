using System;


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main method started...");
        DoSomething();
        Console.WriteLine("Main method ended.....");
        Console.Read();
    }

    private static async void DoSomething()
    {
        Console.WriteLine("Some method started...");

        await Wait();

        Console.WriteLine("Some method ended...");
    }

    private static async Task Wait()
    {
        int seconds = 5;
        await Task.Delay(TimeSpan.FromSeconds(seconds));
        Console.WriteLine();
        Console.WriteLine($"{seconds} seconds wait has ended");
        Console.WriteLine();
    }
}