using System;
using System.Diagnostics;
using CreditCardAsyncExampleApp;



public class Program
{
    private static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.WriteLine("Main Thread started.....");

        List<CreditCard> creditCards = CreditCard.GenerateCreditCards(10000000);
        Console.WriteLine($"Credit cards generated {creditCards.Count}");

        ProcessCreditCards(creditCards);

        Console.WriteLine("Main Thread Completed.....");
        stopwatch.Stop();
        Console.WriteLine($"Main thread excution time {stopwatch.ElapsedMilliseconds / 1000.0} seconds");
        Console.ReadKey();
    }

    public static async Task<string> ProcessCard(CreditCard creditCard)
    {
        await Task.Delay(1000);
        string message = $"Credit Card Number: {creditCard.CardNumber} with Name: {creditCard.Name} is processed";

        // Console.WriteLine($"Card #{creditCard.CardNumber} is processed");
        return message;
    }

    public static async void ProcessCreditCards(List<CreditCard> creditCards)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        List<Task<string>> tasks = new();

        await Task.Run(() =>
        {
            foreach (var creditCard in creditCards)
            {
                var responce = ProcessCard(creditCard);
                tasks.Add(responce);
            }
        });

        await Task.WhenAll(tasks);
        stopwatch.Stop();
        Console.WriteLine($"Processing of {creditCards.Count} credit cards is done in {stopwatch.ElapsedMilliseconds / 1000.0} seconds");
    }
}