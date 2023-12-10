using System;


namespace ConsoleInputOutputExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Print a String**********");
        Console.WriteLine("==================================");
        {
            Console.WriteLine("Hello classic Main <3");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Write vs. WriteLine**********");
        Console.WriteLine("=======================================");
        {
            Console.WriteLine("Console.WriteLine()");
            Console.WriteLine("Prints on ");
            Console.WriteLine("New line");

            Console.WriteLine();

            Console.WriteLine("Console.Write()");
            Console.Write("Prints on ");
            Console.Write("same line");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Printing Variables*********");
        Console.WriteLine("=====================================");
        {
            // printing variable
            int number = 50;
            Console.WriteLine("variable: " + number);

            // printing literals
            Console.WriteLine("Literal: " + 50.05f);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********(+) Operator to combine strings*********");
        Console.WriteLine("==================================================");
        {
            int number = 55;
            Console.WriteLine("Hello " + "C#");
            Console.WriteLine("Number: " + number);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********String Formatting*********");
        Console.WriteLine("====================================");
        {
            int number = 545;
            Console.WriteLine("Number: {0}", number);

            int number1 = 15;
            int number2 = 20;

            int sum = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Inputing a String*********");
        Console.WriteLine("====================================");
        {
            Console.Write("Please enter your name: ");
            string str = Console.ReadLine() ?? string.Empty;

            Console.WriteLine($"You inputed: {str}");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Read() vs. ReadKey()*********");
        Console.WriteLine("=======================================");
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Good Job!!!!");

            Console.Write("Input using Read() - ");
            int userInput = Console.Read();
            Console.WriteLine("ASCII value: {0}", userInput);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Reading Numberic Values*********");
        Console.WriteLine("==========================================");
        {
            Console.Write("Pleaase enter an integer: ");
            string userInput = Console.ReadLine() ?? string.Empty;

            // covert user input to integer
            int intVal = Convert.ToInt32(userInput);
            Console.WriteLine($"You entered: {intVal}");

            Console.Write("Pleaase enter a floating point number: ");
            userInput = Console.ReadLine() ?? string.Empty;

            // conver userInput to a floating point number
            float floatValue = Convert.ToSingle(userInput);
            Console.WriteLine($"You entered: {floatValue}");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Another Way for Numberic Values*********");
        Console.WriteLine("==================================================");
        {
            Console.Write("please enter an integer value: ");
            int intVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: {0}", intVal);

            Console.Write("please enter a double literal: ");
            double doubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You've entere a double value of {0}", doubleValue);
        }

        Console.ReadKey();
    }
}
