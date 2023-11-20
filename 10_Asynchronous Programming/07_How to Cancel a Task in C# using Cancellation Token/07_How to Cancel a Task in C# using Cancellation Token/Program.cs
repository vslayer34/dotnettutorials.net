namespace _07_How_to_Cancel_a_Task_in_C__using_Cancellation_Token;

internal class Program
{
    private static async Task Main(string[] args)
    {
        CancellationTokenSource cancellationTokenSource = new();

        cancellationTokenSource.CancelAfter(5000);


        try
        {
            await LongRunningTask(cancellationTokenSource.Token);
        }
        catch (TaskCanceledException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static async Task LongRunningTask(CancellationToken token)
    {
        while (true)
        {
            // do someting

            if (token.IsCancellationRequested)
            {
                throw new TaskCanceledException();
            }
        }
    }
}

