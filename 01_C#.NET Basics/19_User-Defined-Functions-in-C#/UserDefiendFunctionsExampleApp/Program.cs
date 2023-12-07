using System;


namespace UserDefiendFunctionsExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********No Arguments No Return**********");
        Console.WriteLine("==========================================");

        {
            Sum();
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********No Arguments with Return**********");
        Console.WriteLine("============================================");

        {
            int result = GetSum();
            Console.WriteLine($"Sum is {result}");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********With Arguments and no Return**********");
        Console.WriteLine("================================================");

        {
            int x = 10;
            int y = 15;

            Add(x, y);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********With Arguments and Return**********");
        Console.WriteLine("=============================================");

        {
            int x = 6;
            int y = 14;

            int result = GetAdd(x, y);
            Console.WriteLine($"The sum is {result}");
        }

        Console.ReadKey();
    }

    private static void Sum()
    {
        int x = 10;
        int y = 20;

        int sum = x + y;
        Console.WriteLine($"sum of {x} and {y} is {sum}");
    }

    private static int GetSum()
    {
        int x = 10;
        int y = 20;

        int sum = x + y;
        return sum;
    }

    private static void Add(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"{x} + {y} = {sum}");
    }

    private static int GetAdd(int x, int y)
    {
        return x + y;
    }
}
