using System;
using System.Reflection.Emit;


namespace GotoExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********goto Example**********");
        Console.WriteLine("================================");

        {
            Console.WriteLine("1st statement");

            goto labelOne;
            Console.WriteLine("2nd Statement");
            
            labelOne:
            Console.WriteLine("3rd Statement");

            Console.WriteLine("End of this scope statements");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Multible goto Example**********");
        Console.WriteLine("=========================================");

        {
            Console.WriteLine("1st Statement");

            goto labelTwo;
            Console.WriteLine("2nd Statement");
            
            labelOne:
            Console.WriteLine("3rd Statement");

            labelTwo:
            Console.WriteLine("4th Statement");
            
            labelThree:
            Console.WriteLine("5th Statement");

            Console.WriteLine("End of this local scope");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********goto Inside Loops**********");
        Console.WriteLine("=====================================");

        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    goto labelFive;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Next statement placed after the for loop");

            labelFive:
            Console.WriteLine("Jump from the label");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********goto Inside switch Statements**********");
        Console.WriteLine("=================================================");

        {
            int number = 20;

            switch (number)
            {
                case 5:
                    Console.WriteLine("case 5");
                    break;
                
                case 10:
                    Console.WriteLine("case 10");
                    break;
                
                case 20:
                    Console.WriteLine("case 20");
                    goto case 5;
                
                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********goto to Print numbers to n**********");
        Console.WriteLine("==============================================");

        {
            int count = 1;

            labelLoop:
            Console.Write(count + " ");
            count++;

            if (count <= 10)
            {
                goto labelLoop;
            }
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');

        Console.ReadKey();
    }
}
