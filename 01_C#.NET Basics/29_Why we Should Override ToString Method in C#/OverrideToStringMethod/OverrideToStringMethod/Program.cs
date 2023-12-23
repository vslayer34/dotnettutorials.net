namespace OverrideToStringMethod;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********ToString() Inherited Methods**********");
        Console.WriteLine("================================================");
        
        {
            int number = 10;
            Console.WriteLine(number.ToString());
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********ToString() for classes**********");
        Console.WriteLine("==========================================");

        {
            Employee emp = new();
            emp.FirstName = "Azza";
            emp.LastName = "Rana";

            Console.WriteLine(emp.ToString());
        }
        // The above code would print: OverrideToStringMethod.Employee


        Console.ReadKey();
    }
}

public class Employee
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    // Overriding the ToString() Method in C#:
    public override string ToString() => $"{FirstName} {LastName}";
}
