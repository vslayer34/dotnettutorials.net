using System;


namespace WhileLoopExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Basic While Loop**********");
        Console.WriteLine("====================================");

        {
            int x = 1;

            while (x <= 5)
            {
                Console.WriteLine($"x value: {x}");
                x++;
            }
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Even Numbers Loop**********");
        Console.WriteLine("=====================================");

        {
            int startNum = 2;

            Console.Write("Please enter the last number: ");
            int endNum = Convert.ToInt32(Console.ReadLine());

            while (startNum <= endNum)
            {
                Console.Write(startNum + " ");
                startNum += 2;
            }
            Console.WriteLine();
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Fibonacci series up to a Number**********");
        Console.WriteLine("===================================================");

        {
            Console.Write("Please enter the last number: ");
            int lastNum = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int j = 1;
            Console.Write($"{i} {j}");

            int k = i + j;
            while (k <= lastNum)
            {
                Console.Write($" {k}");

                i = j;
                j = k;
                k = i + j;
            }
            Console.WriteLine();
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Nested While Loop**********");
        Console.WriteLine("=====================================");

        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i <= num)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write($"{j} ");
                    j++;
                }
                i++;
            }
        }

        Console.ReadKey();
    }
}
