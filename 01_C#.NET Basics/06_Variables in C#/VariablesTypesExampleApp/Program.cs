using System;


namespace VariablesTypesExampleApp;
class Program
{
    // Constant variable
    public const float PI = 3.14f;
    // static variable
    private static int staticVariable = 100;

    // Instance Variable
    public int instanceVariable = 200;

    // Readonly variable
    private readonly int readonlyVariable;

    // Class constructor
    public Program(int value, int firstTime)
    {
        instanceVariable = value;
        readonlyVariable = firstTime;
    }

    public Program() { }
    private static void Main(string[] args)
    {
        // Accessing the static variable without an instance
        Console.WriteLine($"staticVariable value: {staticVariable}");

        // Acessing the constant variable without an instance
        Console.WriteLine($"Value of PI is: {PI}");

        Program program1 = new(400, 1);
        Program program2 = new(800, 10);
        Console.WriteLine($"program1 instanceVariable value: {program1.instanceVariable}");
        Console.WriteLine($"progrma2 instanceVariable valueL {program2.instanceVariable}");

        Console.WriteLine($"program1 readonlyVariable value: {program1.readonlyVariable}");
        Console.WriteLine($"progrma2 readonlyVariable valueL {program2.readonlyVariable}");

        Console.ReadKey();
    }

    public void NonStaticBlock()
    {
        // By default, every local variable is gonna be non-static
        // The scope is limited to this method only
        int localVariable = 10;
    }

    public static void StaticBlock()
    {
        // By default, every local variable is gonna be static
        // The scope is limited to this method only
        int localStaticVariable = 5;
    }
}
