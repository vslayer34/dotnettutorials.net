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

        AddHeader("Armstrong Numbers");
        // An Armstrong Number is a number that is equal to the sum of, the power of each digit by the total number of digits.
        // For example, the numbers such as 0, 1, 153, 370, 371, 407, 1634, 8208, 9474 are Armstrong numbers.
        // Let us have a look at the following diagram which shows how the Armstrong number is calculated.

        // 371 = (3 * 3 * 3) + (7 * 7 * 7) + (1 * 1 * 1)
        // 371 =      27     +     343     +      1

        // 8208 = (8 * 8 * 8 * 8) + (2 * 2 * 2 * 2) + (0 * 0 * 0 * 0) + (8 * 8 * 8 * 8)
        // 8208 =      4096       +        16       +        0        +       4096

        {
            int[] digitArray = new int[10];
            int digitCount = 0;

            // Get the input
            Console.Write("Please enter the number: ");
            int.TryParse(Console.ReadLine(), out int number);

            int temp = number;
            int i = 0;

            while (temp > 0)
            {
                digitArray[i++] = temp % 10;
                temp /= 10;
                digitCount++;
            }

            double sum = 0;
            for (int count = 0; count < digitCount; count++)
            {
                sum += MathF.Pow(digitArray[count], digitCount);
            }


            if (sum == number)
            {
                Console.WriteLine($"{number} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number");
            }
        }

        AddHeader("Prime Number Example");

        {
            int number;
            int i;

            Console.Write("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i < number; i++)
            {
                if (number % i ==  0)
                {
                    break;
                }
            }

            if (i == number && number >= 2)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} isn't a prime number.");
            }   
        }

        AddHeader("Fibonacci Series Example");

        {
            int number;
            int number1 = 0;
            int number2 = 1;
            int temp;

            Console.Write("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1)
            {
                Console.Write($"{number1} {number2}");
                temp = number1 + number2;

                for (; temp <= number;)
                {
                    Console.Write($" {temp}");
                    number1 = number2;
                    number2 = temp;
                    temp = number1 + number2;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a number greater than zero (0)");
            }
        }

        Console.ReadKey();
    }
}
