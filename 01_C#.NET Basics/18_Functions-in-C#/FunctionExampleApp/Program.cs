using System;


namespace FunctionExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Built-in Function**********");
        Console.WriteLine("=====================================");

        {
            int number = 25;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is: {squareRoot}");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');

        Console.ReadKey();
    }

    // example of user-defined functions
    public int GetMax(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    private static int Add(int a, int b) => a + b;
}
