using System;


namespace ContinueStatementExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********continue Example**********");
        Console.WriteLine("====================================");

        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine($"I: {i}");
            }
        }

        Console.WriteLine('\n' + new string('=',100) + '\n');
        Console.WriteLine("**********continue within Nested Loops**********");
        Console.WriteLine("================================================");

        {
            for (int outer = 1; outer <= 5; outer++)
            {
                Console.WriteLine($"Outer: {outer}");

                for (int inner = 1; inner <= 5; inner++)
                {
                    if (inner == outer)
                    {
                        continue;
                    }

                    Console.WriteLine($"=> {inner}");
                }

                Console.WriteLine();
            }
        }

        Console.WriteLine('\n' + new string('=',100) + '\n');
        Console.WriteLine("**********if statement insteat of continue (same example)**********");
        Console.WriteLine("===================================================================");

        {
            for (int outer = 1; outer <= 5; outer++)
            {
                Console.WriteLine($"Outer: {outer}");

                for (int inner = 1; inner <= 5; inner++)
                {
                    if (inner != outer)
                    {
                        Console.WriteLine($"=> {inner}");
                    }
                }

                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
}
