using System;


namespace EmployeeDetailsExampleAPP;

class Program
{
    private static void Main(string[] args)
    {
        // Ask the user to enter the empolyee detatils
        Console.WriteLine("Enter Employee details:");

        Console.Write("Enter employee ID: ");
        int employeeId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter employee name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter employee salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter employee address: ");
        string address = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter employee department: ");
        string department = Console.ReadLine() ?? string.Empty;


        // Display the entered employee details

        Console.WriteLine(new string('-', 70));
        Console.WriteLine($"|{"ID".PadRight(3)}|{"Name".PadRight(20)}|{"Salary".PadRight(10)}|{"Address".PadRight(20)}|{"Department".PadRight(11)}|");
        Console.WriteLine(new string('-', 70));
        Console.WriteLine($"|{employeeId.ToString("000")}|{name.PadRight(20)}|{salary.ToString(".00").PadRight(10)}|{address.PadRight(20)}|{department.PadRight(11)}|");
    }
}