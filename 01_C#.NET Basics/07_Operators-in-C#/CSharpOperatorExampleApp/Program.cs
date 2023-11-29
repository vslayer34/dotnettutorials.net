using System;


namespace CSharpOperatorExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Arithmetic Operators**********");
        Console.WriteLine("========================================");

        {
            int result;
            int num1 = 20;
            int num2 = 10;

            int longestString = "Multiplication Operator: ".Length;

            // Addition Operation
            result = num1 + num2;
            Console.WriteLine("Addition Operator: ".PadRight(longestString) + $"{num1} + {num2} = {result}");

            // Subtraction Operation
            result = num1 - num2;
            Console.WriteLine("Subtraction Operator: ".PadRight(longestString) + $"{num1} - {num2} = {result}");

            // Multiplication Operation
            result = num1 * num2;
            Console.WriteLine("Multiplication Operator: ".PadRight(longestString) + $"{num1} * {num2} = {result}");

            // Division Operation
            result = num1 / num2;
            Console.WriteLine("Division Operator: ".PadRight(longestString) + $"{num1} / {num2} = {result}");

            // Modulus Operation
            result = num1 % num2;
            Console.WriteLine("Modulus Operator: ".PadRight(longestString) + $"{num1} % {num2} = {result}");
        }

        Console.WriteLine('\n' + "==============================================================================" + '\n');

        Console.WriteLine("**********Assignment Operators**********");
        Console.WriteLine("========================================");

        {
            int longestString = "x after multiply assignmet (*=) operator: ".Length;
            
            // Initialize variable x using simple assignment operator
            int x = 15;

            x += 10;            // it means x = x + 10;
            Console.WriteLine($"x after add assignmet (+=) operator: ".PadRight(longestString) + $"{x}");

            // Initialize variable x again
            x = 20;
            x -= 5;             // it means x = x - 5;
            Console.WriteLine($"x after subtract assignmet (-=) operator: ".PadRight(longestString) + $"{x}");

            // Initialize variable x again
            x = 15;
            x *= 5;             // it means x = x * 5;
            Console.WriteLine($"x after multiply assignmet (*=) operator: ".PadRight(longestString) + $"{x}");

            // Initialize variable x again
            x = 25;
            x /= 5;             // it means x = x / 5;
            Console.WriteLine($"x after division assignmet (/=) operator: ".PadRight(longestString) + $"{x}");

            // Initialize variable x again
            x = 25;
            x %= 5;             // it means x = x % 5;
            Console.WriteLine($"x after Modulos assignmet (%=) operator: ".PadRight(longestString) + $"{x}");
        }

        Console.WriteLine('\n' + "==============================================================================" + '\n');

        Console.WriteLine("**********Relational Operators**********");
        Console.WriteLine("========================================");

        {
            bool result;
            int num1 = 5;
            int num2 = 10;

            int longestString = "Greater than or equal to (>=) operator: ".Length;

            // Equal Operator
            result = num1 == num2;
            Console.WriteLine("Equal (==) to operator: ".PadRight(longestString) + $"{result}");

            // Greater than Operator
            result = num1 > num2;
            Console.WriteLine("Greater (>) than operator: ".PadRight(longestString) + $"{result}");

            // Less than Operator
            result = num1 < num2;
            Console.WriteLine("Less (<) than operator: ".PadRight(longestString) + $"{result}");

            // Greater than or equal to Operator
            result = num1 >= num2;
            Console.WriteLine("Greater than or equal to (>=) operator: ".PadRight(longestString) + $"{result}");

            // Less than or equal to Operator
            result = num1 <= num2;
            Console.WriteLine("Less than or equal to (<=) operator: ".PadRight(longestString) + $"{result}");

            // Not equal to Operator
            result = num1 != num2;
            Console.WriteLine("Not equal to (!=) operator: ".PadRight(longestString) + $"{result}");
        }

        Console.WriteLine('\n' + "==============================================================================" + '\n');

        Console.WriteLine("**********logical Operators**********");
        Console.WriteLine("=====================================");

        {
            bool result;
            bool trueBool = true;
            bool falseBool = false;

            // Logical AND operator
            result = trueBool && falseBool;
            Console.WriteLine("Logical AND operator: " + result);

            // Logical OR operator
            result = trueBool || falseBool;
            Console.WriteLine("Logical OR operator:  " + result);

            // Logical NOT operator
            result = !trueBool;
            Console.WriteLine("Logical NOT operator: " + result);
        }

        Console.WriteLine('\n' + "==============================================================================" + '\n');

        Console.WriteLine("**********Bitwise Operators**********");
        Console.WriteLine("=====================================");

        {
            int a = 12;
            int b = 25;
            int result;

            //Bitwise AND operator
            result = a & b;
            Console.WriteLine("Bitwise AND operator: " + result);

            //Bitwise OR operator
            result = a | b;
            Console.WriteLine("Bitwise OR operator:  " + result);

            //Bitwise XOR operator
            result = a ^ b;
            Console.WriteLine("Bitwise XOR operator: " + result);
        }

        {
            Console.WriteLine("Boolean Operands");
            bool a = true;
            bool b = false;
            bool result;

            //Bitwise AND operator
            result = a & b;
            Console.WriteLine("Bitwise AND operator: " + result);

            //Bitwise OR operator
            result = a | b;
            Console.WriteLine("Bitwise OR operator:  " + result);

            //Bitwise XOR operator
            result = a ^ b;
            Console.WriteLine("Bitwise XOR operator: " + result);
        }

        Console.WriteLine('\n' + "==============================================================================" + '\n');

        Console.WriteLine("**********Unary Operators**********");
        Console.WriteLine("===================================");

        {
            // post-increment
            int x = 10;

            // result is assigned 10 only
            // x is not updated yet
            int result1 = x++;
            // x is now 11

            Console.WriteLine($"x is {x} and result1 is {result1}");


            // pre-increment
            int y = 10;
            int result2 = ++y;
            // y and result2 has the same value of 11
            
            Console.WriteLine($"y is {y} and result2 is {result2}");
        }

        Console.WriteLine("Decrement");

        {
            // post-decrement
            int x = 10;

            // result is assigned 10 only
            // x is not updated yet
            int result1 = x--;
            // x is now 11

            Console.WriteLine($"x is {x} and result1 is {result1}");


            // pre-decrement
            int y = 10;
            int result2 = --y;
            // y and result2 has the same value of 11
            
            Console.WriteLine($"y is {y} and result2 is {result2}");
        }

        Console.ReadKey();
    }
}
