using System;
using System.ComponentModel;


namespace ForLoopExampleApp;
class Program
{
    private static string _title;
    public static string Title
    {
        set => _title = "*****" + value + "*****";
        get => _title;
    }

    private static void AddHeader(string title, bool isFirstHeader = false)
    {
        Title = title;

        if (!isFirstHeader)
        {
            Console.WriteLine('\n' + new string('=', Title.Length) + '\n');
        }

        Console.WriteLine(Title);
        Console.WriteLine(new string('=', Title.Length));
    }
    private static void Main(string[] args)
    {
        AddHeader("For Loop Example", true);

        {
            Console.Write("Enter one integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

        AddHeader("Nested for Loop");

        {
            // outer for loop;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Outer for loop: {i}");

                // inner for loop
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($" {j}");
                }
                Console.WriteLine();
            }
        }

        AddHeader("Perfect Number Example");

        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            
            if (sum == number && number != 0)
            {
                Console.WriteLine($"Number ({number}) is a perfect number");
            }
            else
            {
                Console.WriteLine($"Number ({number}) isn't a perfect number");
            }
        }

        Console.ReadKey();
    }
}
