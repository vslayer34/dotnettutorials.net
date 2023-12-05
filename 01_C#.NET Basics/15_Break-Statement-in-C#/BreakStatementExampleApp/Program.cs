using System;


namespace BreakStatementExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Break Statement Example**********");
        Console.WriteLine("===========================================");


        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"I: {i}");
                
                if (i == 5)
                {
                    break;
                }
            }
            Console.WriteLine("Out of loop");
        }

        Console.WriteLine('\n' + "=================================================================" + '\n');
        Console.WriteLine("**********Break Statement with Inner Loop**********");
        Console.WriteLine("===================================================");

        {
            for (int outer = 1; outer <= 5; outer++)
            {
                Console.WriteLine($"Outer: {outer}");

                for (int inner = 1; inner <= 5; inner++)
                {
                    if (inner > 3)
                    {
                        break;
                    }
                    Console.Write($"Inner: {inner} ");
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine('\n' + "=================================================================" + '\n');
        Console.WriteLine("**********Break Statement with Loop and Switch**********");
        Console.WriteLine("===================================================");

        {
            double[] measurments = { 1, 20, 3, double.NaN };

            foreach (var measurement in measurments)
            {
                switch (measurement)
                {
                    case 1:
                        Console.WriteLine($"Value of measurement {measurement} is too low");
                        break;
                    
                    case 20:
                        Console.WriteLine($"Value of measurement {measurement} is too hight");
                        break;
                    
                    case double.NaN:
                        Console.WriteLine($"Invalid number");
                        break;
                    
                    default:
                        Console.WriteLine($"Value is {measurement}");
                        break;
                }
            }
        }

        Console.ReadKey();
    }
}
