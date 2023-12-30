using ConstructorDemo.Classes;


namespace ConstructorDemo;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********Implict Constructor Example**********");
        Console.WriteLine("===============================================");

        {
            First f1 = new();
            First f2 = new();
            First f3 = new();

            Console.WriteLine($"{f1.X}\n" + $"{f2.X}\n" + $"{f3.X}");
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********explicit parameterized constructor**********");
        Console.WriteLine("======================================================");

        {
            Second s1 = new Second(100);
            Second s2 = new Second(200);
            Second s3 = new Second(300);

            Console.WriteLine($"{s1.X}\n" + $"{s2.X}\n" + $"{s3.X}");
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');


        {
            Employee emp1 = new(101, 26, "Rana", "Loran", true);
            emp1.Display();
            Console.WriteLine();

            Employee emp2 = new(102, 28, "Azza", "Toson", true);
            emp2.Display();
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Copy constructor**********");
        Console.WriteLine("====================================");

        {
            Employee emp1 = new(103, 31, "Sara", "Loran", true);
            emp1.Display();
            Console.WriteLine();

            Employee emp2 = new(emp1);
            emp2.Display();
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Static constructor**********");
        Console.WriteLine("====================================");

        {
            StaticConstructor example1 = new();
            example1.Increment();
            example1.Display();
            example1.Increment();
            example1.Display();

            Console.WriteLine();

            StaticConstructor example2 = new();
            example2.Increment();
            example2.Display();
            example2.Increment();
            example2.Display();
        }

        Console.WriteLine();
    }
}
