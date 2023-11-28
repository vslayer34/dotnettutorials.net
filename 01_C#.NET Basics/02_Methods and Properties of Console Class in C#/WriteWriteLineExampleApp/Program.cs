using System;


namespace WriteWriteLineExampleApp;

class Program
{
    private static void Main(string[] args)   
    {
        // we can access Write and WriteLine methods using the class name
        // as the methods are static

        // WriteLine prints the value and moves the courser to the next line
        Console.WriteLine("Hello!");

        // Write Method Print the value and stay in the same line
        Console.Write("HI ");
        
        // Write Method Print the value and stay in the same line
        Console.Write("Bye ");

        // WriteLine prints the value and moves the courser to the next line
        Console.WriteLine("Welcome");

        // Write Method Print the value and stay in the same line
        Console.Write("C# .Net");
        Console.ReadKey();
    }
}