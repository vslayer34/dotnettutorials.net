using PropertyDemo.classes;

namespace PropertyDemo;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********Property Basic Example**********");
        Console.WriteLine("==========================================");
        {
            Employee employee = new();
            // We cannot access the private data members
            // So, using public properties (SET Accessor) we are setting the values of private data members
            employee.ID = 101;
            employee.Name = "Rana";
            employee.Age = 26;
            employee.Address = "N/A";

            // Using public properties (Get Accessor) we are Getting the values of private data members
            Console.WriteLine("Emplyee details:");
            Console.WriteLine($"Employee ID: {employee.ID}");
            Console.WriteLine($"Emplyee name: {employee.Name}");
            Console.WriteLine($"Employee age: {employee.Age}");
            Console.WriteLine($"Emplyee address: {employee.Address}");
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Read/Write only property Example**********");
        Console.WriteLine("====================================================");

        {
            Calculator calculator = new();
            Console.WriteLine("Please enter two numbers: ");

            calculator.Number1 = int.Parse(Console.ReadLine() ?? "0");
            calculator.Number2 = int.Parse(Console.ReadLine() ?? "0");

            calculator.Add();
            Console.WriteLine($"The sum is: {calculator.Result}");

            calculator.Subtract();
            Console.WriteLine($"The sub is: {calculator.Result}");

            calculator.Multiply();
            Console.WriteLine($"The multification is: {calculator.Result}");

            calculator.Divide();
            Console.WriteLine($"The division is: {calculator.Result}");

        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Auto Implemented properties Example**********");
        Console.WriteLine("====================================================");

        {
            Student student = new();

            student.ID = 101;
            student.Name = "Rana";
            student.Age = 26;
            student.Address = "N/A";

            Console.WriteLine("Emplyee details:");
            Console.WriteLine($"Employee ID: {student.ID}");
            Console.WriteLine($"Emplyee name: {student.Name}");
            Console.WriteLine($"Employee age: {student.Age}");
            Console.WriteLine($"Emplyee address: {student.Address}");
        }

        Console.ReadKey();
    }
}
