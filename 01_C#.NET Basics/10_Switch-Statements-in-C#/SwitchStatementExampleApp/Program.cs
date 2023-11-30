using System;


namespace SwitchStatementExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Basic Switch Statement**********");
        Console.WriteLine("==========================================");

        {
            int x = 2;
            
            switch (x)
            {
                case 1:
                    Console.WriteLine("Choice is 1");
                    break;
                case 2:
                    Console.WriteLine("Choice is 2");
                    break;
                case 3:
                    Console.WriteLine("Choice is 3");
                    break;
                default:
                    Console.WriteLine("Choice is another than 1,2 or 3");
                    break;
            }
        }

        Console.WriteLine('\n' + "=================================================================" + '\n');
        Console.WriteLine("**********Combining Cases**********");
        Console.WriteLine("===================================");

        {
            string str = "C#";

            switch (str)
            {
                case "C#":
                case "Java":
                case "C":
                    Console.WriteLine("It's a programming language");
                    break;
                
                case "MSSQL":
                case "MySQL":
                case "Oracle":
                    Console.WriteLine("It's a database");
                    break;
                
                case "MVC":
                case "Web API":
                    Console.WriteLine("It's a framework");
                    break;
                
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        Console.WriteLine('\n' + "=================================================================" + '\n');
        Console.WriteLine("**********Nested switch Statement**********");
        Console.WriteLine("===========================================");

        {
            // Prompt the user to enter a number between 1 and 3
            Console.Write("Please, enter a number between 1 & 3: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Outer switch statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered 1");
                    // Prompt the user to enter character from (R,G,B)
                    Console.Write("Please, enter a color code (R/G/B): ");
                    char color = Convert.ToChar(Console.ReadLine());

                    // Inner switch statement
                    switch (color)
                    {
                        case 'R':
                        case 'r':
                            Console.WriteLine("You've selected color: Red");
                            break;
                        
                        case 'B':
                        case 'b':
                            Console.WriteLine("You've selected color: Blue");
                            break;
                        
                        case 'G':
                        case 'g':
                            Console.WriteLine("You've entered color: Green");
                            break;

                        default:
                            Console.WriteLine("You've entered an invalid color");
                            Console.WriteLine($"Code: {char.ToUpper(color)}");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("You entered 2");
                    break;
                
                case 3:
                    Console.WriteLine("You entered 3");
                    break;
                
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }

        Console.ReadKey();
    }
}
