using System.Diagnostics;

namespace _07_How_to_Cancel_a_Task_in_C__using_Cancellation_Token;

internal class Program
{
    private static void Main(string[] args)
    {
        // SomeMethod();
        // UserInitiatedCancellation();
        // TimeBasedCalculation();
        string name = "rana";
        int failTime = 4000;
        int successTime = 30000;
        TestAPI(name, successTime);
        Console.ReadKey();
    }

    private static async Task UserInitiatedCancellation()
    {
        CancellationTokenSource cts = new();
        cts.CancelAfter(10000);
        int loopTime = 1000000;
        
        await Task.Run(async () =>
        {
            Console.WriteLine("To cancel press 'E'");

            // Long Running Operation
            try
            {
                for (int i = 0; i < loopTime; i++)
                {
                    await Task.Delay(500);
                    Console.WriteLine($"Downloading package {i:0000}");

                    if (cts.IsCancellationRequested)
                    {
                        throw new TaskCanceledException();
                    }
                }
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine("Download Cancelled");
                Console.WriteLine(ex.Message);
            }
            
            // perform some work
        }, cts.Token);
    }
    

    private static async void TestAPI(string name, int allowanceTime)
    {
        Console.WriteLine("TestAPI started....");

        using (HttpClient client = new())
        {
            CancellationTokenSource cts = new(allowanceTime);

            client.BaseAddress = new Uri("http://localhost:5202/");

            try
            {
                Console.WriteLine("TestAPI calling web API..");
                HttpResponseMessage response;
                response = await client.GetAsync($"http://localhost:5202/api/home/name?name={name}", cts.Token);
                string message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Task Excution Cancelled: {ex.Message}");
            }

            Console.WriteLine("TestAPI completed.");
        }
    }
    
    private static async Task TimeBasedCalculation()
    {
        CancellationTokenSource cts = new();
        Timer timer = new(_ => { cts.Cancel(); throw new TaskCanceledException(); }, null, TimeSpan.FromSeconds(5), Timeout.InfiniteTimeSpan);

        await Task.Run(() =>
        {
            while (!cts.IsCancellationRequested)
            {
                try
                {
                    Console.WriteLine("Requesting connection");
                }
                catch (TaskCanceledException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }, cts.Token);
    }

    private static async void SomeMethod()
    {
        int count = 10;
        Console.WriteLine("SomeMethod started...");

        CancellationTokenSource cancellationToken = new();
        cancellationToken.CancelAfter(5000);

        try
        {
            await LongRunningTask(count, cancellationToken.Token);
        }
        catch(TaskCanceledException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("SomeMethod Completed....");
    }

    private static async Task LongRunningTask(int count, CancellationToken token)
    {
        Stopwatch stopWatch = new();
        stopWatch.Start();
        Console.WriteLine("\nLongRunningTask started.....");

        for (int i = 0; i <= count; i++)
        {
            await Task.Delay(1000);
            Console.WriteLine("LonRunningTask Processing....");

            if (token.IsCancellationRequested)
            {
                throw new TaskCanceledException();
            }

            stopWatch.Stop();
            Console.WriteLine($"LongRunningTask Took {stopWatch.ElapsedMilliseconds / 1000.0} seconds for processing");
        }
    }
}
