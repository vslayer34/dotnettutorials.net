using System;


namespace CommonLineArgumentsExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Command Line Arguments in C#**********");
        Console.WriteLine("================================================");

        // passing dotnet run value1 value2 value3
        {
            Console.WriteLine($"First Command Line Argument {args[0]}");
            Console.WriteLine($"Second Command Line Argument {args[1]}");
            Console.WriteLine($"Third Command Line Argument {args[2]}");
        }
        
        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Passing Numeric Command Line Arguments**********");
        Console.WriteLine("==========================================================");

        // passing dotnet run 101 10.5
        {
            // convert into integer type
            int argument1 = Convert.ToInt32(args[3]);
            Console.WriteLine($"Argument in integer form: {argument1}");

            // convert into double type
            double argument2 = Convert.ToDouble(args[4]);
            Console.WriteLine($"Argument in double form: {argument2}");
        }
        
        Console.ReadKey();
    }
}
