using System;


namespace RecurssionExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Function Call Stack**********");
        Console.WriteLine("=======================================");
        
        {
            Console.WriteLine("Main Method Started");
            Fun1(4);
            Console.WriteLine("Main Method Ended");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Recurrsion Method**********");
        Console.WriteLine("=====================================");

        {
            int x = 3;
            PrintValue(x);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Factorial of Number**********");
        Console.WriteLine("=======================================");

        {
            int x = 5;
            Console.WriteLine($"Factorial of {x} is: {GetFactorial(x)}");
        }

        Console.ReadKey();
    }

    private static void Fun1(int n)
    {
        Console.WriteLine("Fun1() Started");
        Fun2(3);
        Console.WriteLine("Fun2() Ended");
    }

    private static void Fun2(int n)
    {
        Console.WriteLine("Fun2() Started");
        Fun3(2);
        Console.WriteLine("Fun2() Ended");
    }

    private static void Fun3(int n)
    {
        Console.WriteLine("Fun3() Started");
        Fun4(1);
        Console.WriteLine("Fun3() Ended");
    }

    private static void Fun4(int n)
    {
        Console.WriteLine("Fun4() Started");
        Console.WriteLine("Fun4() Ended");
    }

    private static void PrintValue(int n)
    {
        if (n > 0)
        {
            Console.Write($"{n} ");
            PrintValue(n - 1);
        }
    }

    private static int GetFactorial(int num)
    {
        if (num == 1)
        {
            return 1;
        }
        else
        {
            return num * GetFactorial(num - 1);
        }
    }
}
