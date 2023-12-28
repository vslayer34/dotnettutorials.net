namespace ConstructorsDemo;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********Implicit Constructors**********");
        Console.WriteLine("=========================================");

        {
            var test = new Test();
            
            Console.WriteLine(test.i);
            Console.WriteLine(test.b);
            Console.WriteLine(test.s ?? "test.s = null");
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Explicit Constructors**********");
        Console.WriteLine("=========================================");

        {
            ExplicitConstructor obj = new();
        }

        Console.WriteLine();
    }
}

public class Test
{
    public int i;
    public bool b;
    public string s;
}

public class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        Console.WriteLine("Explicit constructor is created");
    }
}