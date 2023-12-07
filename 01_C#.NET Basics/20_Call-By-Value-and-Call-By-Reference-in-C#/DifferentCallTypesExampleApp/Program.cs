using System;


namespace DifferentCallTypesExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Call by Value**********");
        Console.WriteLine("=================================");

        {
            int a = 15;
            int b = a;
            b = 30;

            Console.WriteLine(a);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Copy Value in Methods**********");
        Console.WriteLine("=========================================");

        {
            int a = 15;
            UpdateValue(a);
            Console.WriteLine(a);
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Call by Value wit Reference Types**********");
        Console.WriteLine("=====================================================");

        {
            Employee emp1 = new()
            {
                ID = 1001,
                Name = "James"
            };

            Employee emp2 = emp1;
            emp1.Name = "Smith";

            Console.WriteLine($"emp1 name: {emp1.Name}");
            Console.WriteLine($"emp2 name: {emp2.Name}");
        }

        Console.WriteLine('\n' + new string('=', 100) + '\n');
        Console.WriteLine("**********Call by Reference with Value Types**********");
        Console.WriteLine("======================================================");

        {
            int a = 15;
            UpdateValueByRefernece(ref a);
            Console.WriteLine(a);
        }

        Console.ReadKey();
    }

    private static void UpdateValue(int num)
    {
        num = 30;
    }

    private static void UpdateValueByRefernece(ref int a)
    {
        a = 30;
    }
}

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
}