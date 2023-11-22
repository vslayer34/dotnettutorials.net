using System;


namespace TestConsoleApplication;
public class Program
{
    private static void Main()
    {
        Console.WriteLine("Main method started.....");

        SomeMethod1();
        SomeMethod2();
        SomeMethod3();
        SomeMethod4();

        Console.WriteLine("Main method ended.");
        Console.ReadKey();
    }


    // Syntax to use Task.CompletedTask in C#:
    // Method returning a Task but it's synchronous
    private static Task SomeMethod1()
    {
        // Do some task
        Console.WriteLine("SomeMethod1 Executing, It does not return anything");

        return Task.CompletedTask;
    }

    // Syntax to use Task.FromResult in C#:
    // Synchronous method returning Task<T>
    private static Task<string> SomeMethod2()
    {
        string someValue = string.Empty;
        someValue = "SomeMethod2 Returing a String";
        Console.WriteLine("SomeMethod2 Executing, It return a string");

        return Task.FromResult(someValue);
    }

    // Syntax to use Task.FromException in C#:
    // Synchronous method returning task with exception
    private static Task SomeMethod3()
    {
        // Do some task
        Console.WriteLine("SomeMethod3 Executing, It will throw an Exception");

        return Task.FromException(new ApplicationException());
    }

    // Syntax to use Task.FromCanceledin C#:
    // Synchronous method cancelling a task
    private static Task SomeMethod4()
    {
        CancellationTokenSource cts = new(5000);
        cts.Cancel();
        Console.WriteLine("SomeMethod4 Executing, It will Cancel the Task Exception");

        return Task.FromCanceled(cts.Token);
    }
}