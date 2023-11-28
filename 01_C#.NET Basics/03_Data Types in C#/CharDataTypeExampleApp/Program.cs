using System;


namespace CharDataTypeExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        char character = 'B';

        Console.WriteLine($"Char: {character}");
        Console.WriteLine($"Equivalent Number: {Convert.ToByte(character)}");
        Console.WriteLine($"Char Minimum: {Convert.ToInt32(char.MinValue)}");
        Console.WriteLine($"Char Maximum: {Convert.ToInt32(char.MaxValue)}");
        Console.WriteLine($"char Size: {sizeof(char)} Bytes");

        Console.ReadKey();
    }
}