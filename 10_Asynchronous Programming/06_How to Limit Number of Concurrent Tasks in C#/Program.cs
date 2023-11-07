using System;
using System.Diagnostics;


class Program
{
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        Console.WriteLine("Main Thread started");

        List<CreditCard> creditCards = CreditCard.GenerateCreditCards(1000000);
        Console.WriteLine($"Number of generated credit cards: {creditCards.Count}");

        ProcessCreditCards(creditCards);

        Console.WriteLine("Main Thread Completed");
        stopwatch.Stop();
        Console.WriteLine($"Main Thread Excution Time: {stopwatch.ElapsedMilliseconds / 1000.0} seconds");
        Console.ReadKey();
    }


    public static async void ProcessCreditCards(List<CreditCard> creditCards)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();

        List<Task<string>> tasks = new();

        await Task.Run(() =>
        {
            foreach (var card in creditCards)
            {
                Task<string> response = ProcessCard(card);
                tasks.Add(response);
            }
        });

        //It will execute all the tasks concurrently
        await Task.WhenAll(tasks);

        stopwatch.Stop();
        Console.WriteLine($"processing of {creditCards.Count} credit cards done in {stopwatch.ElapsedMilliseconds / 1000.0} seconds");
    }


    public static async Task<string> ProcessCard(CreditCard creditCard)
    {
        await Task.Delay(1000);
        string message = $"Credit card Number {creditCard.CardNumber} owned by {creditCard.Name} is processed";

        return message;
    }
}