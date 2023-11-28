using System;


namespace StudentMarkExampleApp;

class Program
{
    private static void Main(string[] args)
    {
        // Ask the user to enter the student details
        Console.WriteLine("Rnter students details:");

        Console.Write("Registeration Number: ");
        int regNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Enter the marks of the 3 subjects:");

        Console.Write("Subject 1: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 2: ");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 3: ");
        int mark3 = Convert.ToInt32(Console.ReadLine());

        int totalMarks = mark1 + mark2 + mark3;
        int averageMarks = totalMarks / 3;


        // Display the student details
        Console.WriteLine();
        Console.WriteLine("Student details are as follows");
        Console.WriteLine($"Registeration Number: {regNumber:0000}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Average Marks: {averageMarks}");

        Console.ReadKey();
    }    
}