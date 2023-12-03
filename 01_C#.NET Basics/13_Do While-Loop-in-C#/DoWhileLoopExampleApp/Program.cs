using System;
using System.Runtime.InteropServices.Marshalling;


namespace DoWhileLoopExampleApp;
class Program
{
    private static string stars = "**********";
    private static string _title = string.Empty;

    public static string Title
    {
        set
        {
            _title = stars + value + stars;
        }

        get => _title;
    }

    private static string GetRuler() => '\n' + "=======================================================" + '\n';
    private static void Main(string[] args)
    {
        Title = "Do While Loop";
        Console.WriteLine(Title);
        Console.WriteLine(new string('=', Title.Length));

        {
            int number = 1;

            do
            {
                Console.Write(number + " ");
                number++;
            } while (number <= 5);

            Console.WriteLine();
        }

        Console.WriteLine(GetRuler());
        Title = "Nested Do-While Loop";
        Console.WriteLine(Title);
        Console.WriteLine(new string('=', Title.Length));

        {
            do
            {
                Console.WriteLine("I'm in the outer loop");

                do
                {
                    Console.WriteLine("I'm in the inner loop");
                } while (1 > 10);

            } while (2 > 10);
        }

        Console.WriteLine(GetRuler());
        Title = "Realtime Example for do-while Loop";
        Console.WriteLine(Title);
        Console.WriteLine(new string('=', Title.Length));

        {
            char choice;
            int menuOption;
            int number1, number2;

            do
            {
                Console.WriteLine("Press 1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division");
                menuOption = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Enter the value of the two numbers");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                        break;
                    
                    case 2:
                        Console.WriteLine("Enter the value of the two numbers");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                        break;

                    case 3:
                        Console.WriteLine("Enter the value of the two numbers");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                        break;

                    case 4:
                        Console.WriteLine("Enter the value of the two numbers");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("Please enter y to continue, any other key to ext...");

                choice = Convert.ToChar(Console.ReadLine());
            
            } while (Char.ToLower(choice).Equals('y'));
        }

        Console.WriteLine("Closing the app....");

        Console.ReadKey();
    }
}
