using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;


class Program
{
    // allow a maximum of 3 tasks to be excuted at a time
    private static SemaphoreSlim semaphoreSlim = new(3);
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        Console.WriteLine("Main Thread started");

        List<CreditCard> creditCards = CreditCard.GenerateCreditCards(15);
        Console.WriteLine($"Number of generated credit cards: {creditCards.Count}");

        ProcessCreditCards(creditCards);

        Console.WriteLine("Main Thread Completed");
        stopwatch.Stop();
        Console.WriteLine($"Main Thread Excution Time: {stopwatch.ElapsedMilliseconds / 1000.0} seconds");
        Console.ReadKey();
    }

    /*
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
    */

    public static async void ProcessCreditCards(List<CreditCard> creditCards)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();

        List<Task<string>> tasks = new();

        // We need to use async lamda expression
        tasks = creditCards.Select(async card =>
        {
            // this will tell if we have more than 3 tasks running
            // and would wait untill the semaphore is released
            await semaphoreSlim.WaitAsync();

            // we need to use the wait operator as we're using semaphore WaitAsync
            try
            {
                return await ProcessCard(card);
            }
            finally
            {
                // release the semaphore
                semaphoreSlim?.Release();
            }

        }).ToList();

        // It will execute all the tasks concurrently
        //await Task.WhenAll(tasks);

        // recieve the task response
        string[] responses = await Task.WhenAll(tasks);

        foreach (string response in responses)
        {
            Console.WriteLine(response);
        }

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