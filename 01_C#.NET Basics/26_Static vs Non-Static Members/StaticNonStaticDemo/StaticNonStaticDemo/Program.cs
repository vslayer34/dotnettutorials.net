using System.ComponentModel;

namespace StaticNonStaticDemo;

internal class Program
{
    private int x;                          // Non-static variable
    private static int y = 200;             // static variable

    public Program(int x)
    {
        // Initializing non-static variables
        this.x = x;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("**********Example of Static and Non-Static Variables**********");
        Console.WriteLine("==============================================================");

        {
            // Accessing static variable using class name
            // Before object creation
            Console.WriteLine($"Static variable y = {Program.y}");

            // Accessing static variable without class name
            // That's because the Main method is in the same class
            Console.WriteLine($"Static variable y: {y}");

            // Creating object #1
            Program obj1 = new(50);

            // Creating object #2
            Program obj2 = new(100);

            // Acessing non-static variable using class's objects
            Console.WriteLine($"Object #1: x = {obj1.x}\n" + $"Object #2: x = {obj2.x}");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Example of Static and Non-Static Methods**********");
        Console.WriteLine("============================================================");

        {
            // Main method is a static method
            // Add() method is a static method
            Example.Add();                      // Calling Add() method through class name

            // Multiply() is a non-static method
            var exampleObj = new Example();
            exampleObj.Multiply();
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Example of Static and Non-Static Constructors**********");
        Console.WriteLine("=================================================================");

        {
            // Program Execution will start from the Main method
            // But before executing the Main method body, it will
            // execute the static constructor
            Console.WriteLine("Third scope in Main method started");
            var obj1 = new StaticConstructorExample();
            var obj2 = new StaticConstructorExample();
            Console.WriteLine("Third scope in Main method ended");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Example of Static Class**********");
        Console.WriteLine("===========================================");

        {
            Console.WriteLine("Please select the convertor direction: ");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius");
            Console.Write("/: ");

            string selection = Console.ReadLine();
            double fahrenheit = 0.0;
            double celsius = 0.0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    fahrenheit = TemperatureConvertor.ConvertCelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine($"Temperature in Fahrenheit is: {fahrenheit.ToString("0.00")}");
                    break;

                case "2":
                    Console.Write("Please enter hte Fahrenheit temperature: ");
                    celsius = TemperatureConvertor.ConvertFahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine($"Temperature in Celsius is: {celsius.ToString("0.00")}");
                    break;

                default:
                    Console.WriteLine("Please select a convertor");
                    break;
            }
        }

        Console.ReadKey();
    }
}

public static class TemperatureConvertor
{
    public static double ConvertCelsiusToFahrenheit(string temperature = "0")
    {
        // Convert the argument to double for calculations
        double celsius = double.Parse(temperature);

        // Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double ConvertFahrenheitToCelsius(string temperature = "0")
    {
        // Convert the argument to double for calculations
        double fahrenheit = double.Parse(temperature);

        // Convert Fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        return celsius;
    }
}

class Example
{
    private int x = 100;
    private static int y = 200;

    public static void Add()
    {
        // This is a static block
        // we can access non static member x with the help of example object
        // we can access the static member directly through the class
        Example obj = new();
        Console.WriteLine($"sum of 100 and 200: {obj.x + y}");
        Console.WriteLine($"sum of 100 and 200: {obj.x + Example.y}");
    }

    public void Multiply()
    {
        // This is a non-static method
        // we can access static members directly or through class name
        // We can access the non-static members directly or through this keyword
        Console.WriteLine($"Multiplication of 100 and 200 is: {this.x * Example.y}");
        Console.WriteLine($"Multiplication of 100 and 200 is: {x * y}");
    }
}


class StaticConstructorExample
{
    // Static Constructor
    // Executed only once
    // First block of code to be executed inside a class
    // Before Main Method body start executing, this constructor will execute
    static StaticConstructorExample()
    {
        Console.WriteLine("Static Constructor is called");
    }

    // Non-Static Constructor
    // Executed once per object
    // When we create an instance, this constructor will execute
    public StaticConstructorExample()
    {
        Console.WriteLine("Non-Static constructor is called");
    }


}
