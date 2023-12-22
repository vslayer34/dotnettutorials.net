namespace ConstReadOnlyDemo;

internal class Program
{
    // We need to assign a value to the const variable
    // at the time of const variable declaration else it will
    // give compile time error
    private const float PI = 3.14f;
    private static int x = 10;

    // Non-Static variable
    private int y;

    // readonly variable
    private readonly int z;

    // readonly variable
    private readonly int x1;
    private readonly int x2 = 5;
    private readonly int x3;

    private readonly int number;

    public Program()
    {
        x3 = 20;
    }

    //Initialize Readonly Variable through constructor
    public Program(int num)
    {
        number = num;
    }

    public Program(int a, int b)
    {
        // normal variable
        y = a;

        // readonly variable
        z = b;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("**********Const Example**********");
        Console.WriteLine("=================================");

        {
            // Const variables are static in nature
            // So we can access them by using class name 
            Console.WriteLine(Program.PI);

            // We can also access them directly within the same class
            Console.WriteLine(PI);

            // We can also declare a constant variable within a function
            const int num = 10;
            Console.WriteLine(num);

            // Once after declaration we cannot change the value of a constant variable.
            // So, the below line gives an error
            //num = 20;
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********readonly Example**********");
        Console.WriteLine("====================================");

        {
            Program obj1 = new();
            // Accessing readonly value from the instance
            Console.WriteLine(obj1.x1);
        }

        {
            Program obj1 = new();
            // Accessing readonly value from the instance
            Console.WriteLine(obj1.x2);
        }

        {
            Program obj1 = new();
            // Accessing readonly value from the instance
            Console.WriteLine(obj1.x3);
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********readonly through Constructor Example**********");
        Console.WriteLine("========================================================");

        {
            Program obj1 = new(100);
            Console.WriteLine(obj1.number);

            Program obj2 = new(200);
            Console.WriteLine(obj2.number);
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********const readonly Example**********");
        Console.WriteLine("========================================================");

        {
            // Accessing the static variable without instance
            Console.WriteLine($"x value: {x}");

            // Accessing the constant variable without instance
            Console.WriteLine($"PI value: {PI}");

            // Creating tow instances
            Program obj1 = new(300, 45);
            Program obj2 = new(400, 55);

            // Accessing Non-Static and Readonly variables using instance
            Console.WriteLine($"obj1 y value: {obj1.y}, obj2 readonly z value: {obj1.z}");
            Console.WriteLine($"obj2 y value: {obj2.y}, obj2 readonly z value: {obj2.z}");
        }

        Console.ReadKey();
    }
}