using System;


namespace ReadConsoleValueExampleApp;

class Program
{
    private static void Main(string[] args)
    {
        // Giving a prompt to the user to enter his/her name
        Console.Write("Enter your name: ");

        // ReadLine method reads a string value from the keyboard
        string name = Console.ReadLine() ?? string.Empty;

        // printing the entered string int the console
        Console.WriteLine($"\n***Hello {name}***");
        
        Console.ReadKey();
    }
}