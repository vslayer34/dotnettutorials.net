using System;


namespace IfElseFlowExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********If Statement**********");
        Console.WriteLine("================================");
        {
            const int baseNumber = 10;

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > baseNumber)
            {
                Console.WriteLine($"{number} is greater than the comparison number {baseNumber}");
                Console.WriteLine("End of the if block");
            }

            Console.WriteLine("End of the main method");
        }

        Console.WriteLine('\n' + "======================================================================" + '\n');
        Console.WriteLine("**********If else Statement**********");
        Console.WriteLine("=====================================");

        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an EVEN number.");
            }
            else
            {
                Console.WriteLine($"{number} is an ODD number.");
            }
        }

        Console.WriteLine('\n' + "======================================================================" + '\n');
        Console.WriteLine("**********Nested If Block**********");
        Console.WriteLine("===================================");

        {
            int a = 15;
            int b = 25;
            int c = 10;

            int largeNumber = 0;

            if (a > b)
            {
                Console.WriteLine("Outer if block");

                if (a > c)
                {
                    Console.WriteLine("Outer if block -> Inner if block");
                    largeNumber = a;
                }
                else
                {
                    Console.WriteLine("Outer if block -> inner else block");
                    largeNumber = c;
                }
            }
            else
            {
                Console.WriteLine("Outer else block");

                if (b > c)
                {
                    Console.WriteLine("Outer else block -> Inner if block");
                    largeNumber = b;
                }
                else
                {
                    Console.WriteLine("Outer else block -> Inner else block");
                    largeNumber = c;
                }
            }

            Console.WriteLine($"The largest number is {largeNumber}");
        }

        Console.WriteLine('\n' + "======================================================================" + '\n');
        Console.WriteLine("**********Ternary Operation**********");
        Console.WriteLine("=====================================");

        {
            int a = 15;
            int b = 25;
            int c = 10;

            int largeNumber;

            Console.WriteLine($"a = {a}\t\tb = {b}\t\tc = {c}");
            largeNumber =
                (a > b) ?
                ((a > c) ? a : c) :
                ((b > c) ? b : c);

            Console.WriteLine($"The large number is: {largeNumber}");
        }

        Console.WriteLine('\n' + "======================================================================" + '\n');
        Console.WriteLine("**********Ladder if-else Statement**********");
        Console.WriteLine("============================================");

        {
            int i = 20;

            if (i == 10)
            {
                Console.WriteLine("is is: 10");
            }
            else if (i == 15)
            {
                Console.WriteLine("i is: 15");
            }
            else if (i == 20)
            {
                Console.WriteLine("i is: 20");
            }
            else
            {
                Console.WriteLine("i is not present in the ladder");
            }
        }

        Console.ReadKey();
    }
}
