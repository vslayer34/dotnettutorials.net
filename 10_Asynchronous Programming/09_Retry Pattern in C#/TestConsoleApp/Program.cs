using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace TestConsoleApp;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main method started.....");

        RetryMethod();

        Console.WriteLine("Main method ended.");
        Console.ReadKey();
    }


    private static async void RetryMethod()
    {
        // it tells the number of times the connection should be retried
        int retryTimes = 3;

        // determine the wait time
        int waitTime = 500;

        for (int i = 0; i < retryTimes; i++)
        {
            try
            {
                Console.WriteLine("Starting operation....");
                await RetryOperation();
                Console.WriteLine("Operation Successful");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Retry #{i + 1}: Getting Exception -> {ex.Message}");

                // wait before trying again
                await Task.Delay(waitTime);
            }
        }
    }

    private static async Task RetryOperation()
    {
        Console.WriteLine("Establishing conniction");
        await Task.Delay(500);

        throw new Exception("Exception Occurred in while Processing...\n");
    }
}