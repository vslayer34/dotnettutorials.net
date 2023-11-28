using System;


namespace BooleanLiteralsExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        bool b1 = true;
        bool b2 = false;

        // bool b3 = 1;            // Error
        // bool b4 = 0;            // Error

        Console.WriteLine(b1);
        Console.WriteLine(b2);

        Console.ReadKey();
    }
}
