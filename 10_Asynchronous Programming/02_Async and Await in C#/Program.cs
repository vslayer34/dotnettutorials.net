using System;
using System.Threading.Tasks;


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main method started...");
        DoOtherMethod();
        Console.WriteLine("Main method ended.....");
        Console.ReadKey();
    }


    // example of an async method
    private async void DoSomething()
    {
        // Do something

        await Task.Delay(1000);

        //Do other somethings
    }


    private async static void DoOtherMethod()
    {
        Console.WriteLine("Some method started...");
        
        // Thread.Sleep(TimeSpan.FromSeconds(5));
        await Task.Delay(TimeSpan.FromSeconds(5));
        
        Console.WriteLine('\n');
        Console.WriteLine("Some method ended......");
    }
}