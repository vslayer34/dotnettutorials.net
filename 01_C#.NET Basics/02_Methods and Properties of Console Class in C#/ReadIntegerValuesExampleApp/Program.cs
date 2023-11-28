using System;


namespace ReadIntegerValuesExampleApp;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter two values");

        // Converting first string into integer
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Converting second string into integer
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = num1 + num2;

        Console.WriteLine($"{num1} + {num2} = {result}");

        Console.ReadKey();
    }
}