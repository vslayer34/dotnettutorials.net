using System;


namespace CharacterLiteralExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        // Character literals using single quote
        char ch1 = 'A';

        // Characters literals using unicode representation
        char ch2 = '\u1f62';

        // Characters literals using escape characters
        char ch3 = '\t';

        System.Console.WriteLine($"Single Quote: {ch1}");
        System.Console.WriteLine($"Unicode: {ch2}");
        System.Console.WriteLine($"Escape characters: {ch3}t");
    }
}
