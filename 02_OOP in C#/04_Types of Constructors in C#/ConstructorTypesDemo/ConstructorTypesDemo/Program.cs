using ConstructorTypesDemo.Classes;


namespace ConstructorTypesDemo;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********Implicit Constructors in C#**********");
        Console.WriteLine("===============================================");

        {
            EmployeeImplicit employee = new EmployeeImplicit();
            Console.WriteLine($"Employee ID:      {employee.Id}");
            Console.WriteLine($"Employee Name:    {employee.Name}");
            Console.WriteLine($"Employee Age:     {employee.Age}");
            Console.WriteLine($"Employee Address: {employee.Address}");
            Console.WriteLine($"is permenant:     {employee.IsPermanent}");
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Default or Parameterless Constructors in C#**********");
        Console.WriteLine("===============================================================");

        {
            Employee employee = new Employee();
            employee.DisplayEmployeeInfo();
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Parameterized Constructors in C#**********");
        Console.WriteLine("====================================================");

        {
            ParameterizedConstructor obj1 = new(10);
            obj1.DisplayNumber();

            ParameterizedConstructor obj2 = new(20);
            obj2.DisplayNumber();
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Copy Constructors in C#**********");
        Console.WriteLine("====================================================");

        {
            CopyConstructor copy1 = new(10);
            copy1.DisplayNumber();

            CopyConstructor copy2 = new(copy1);
            copy2.DisplayNumber();
        }

        Console.WriteLine();
    }
}
