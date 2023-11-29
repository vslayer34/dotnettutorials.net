using System;


namespace ControlFlowExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        // Normal Excution of programs
        Console.WriteLine("**********Normal Execution**********");
        Console.WriteLine("====================================");
        {
            int number = 1;
            Console.WriteLine($"Executing Statement #{number++}");
            Console.WriteLine($"Executing Statement #{number++}");
            Console.WriteLine($"Executing Statement #{number++}");
            Console.WriteLine($"Executing Statement #{number++}");
            Console.WriteLine($"Executing Statement #{number++}");
        }

        Console.WriteLine('\n' + "===========================================================================" + '\n');
        Console.WriteLine("**********if/else**********");
        Console.WriteLine("===========================");

        {
            if (10 > 5)
            {
                Console.WriteLine("Executing Statement #1");
                Console.WriteLine("Executing Statement #2");
            }
            else
            {
                Console.WriteLine("Executing Statement #3");
                Console.WriteLine("Executing Statement #4");
            }

            Console.WriteLine("Executing Statement #5");
        }

        Console.WriteLine('\n' + "===========================================================================" + '\n');
        Console.WriteLine("**********for loop**********");
        Console.WriteLine("============================");

        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Executing Statement #{i + 1}");
            }

            Console.WriteLine("Executing Final Statement");
        }

        Console.WriteLine('\n' + "===========================================================================" + '\n');
        Console.WriteLine("**********goto control**********");
        Console.WriteLine("================================");

        {
            Console.WriteLine("Executing Statement #1");

            goto Rana;        // goto label someLabelName;
            Console.WriteLine("Executing Statement #2");
            Console.WriteLine("Executing Statement #3");
            
            Rana:             // label
            Console.WriteLine("Executing Statement #4");
            Console.WriteLine("Executing Statement #5");
        }

        

        Console.ReadKey();
    }
}
