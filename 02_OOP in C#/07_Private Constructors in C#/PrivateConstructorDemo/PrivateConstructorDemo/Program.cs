namespace PrivateConstructorDemo;
internal class Program
{
    public int x;
    // private Constructor
    private Program()
    {
        this.x = 1;
        Console.WriteLine("This is a private constructor");
    }

    public void CallMethod1()
    {
        Console.WriteLine("Method1 is called");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("**********Private Constructor Example**********");
        Console.WriteLine("===============================================");

        {
            // Creating instance of the program class using the private constructor
            Program obj = new();
            obj.CallMethod1();
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Singleton Example**********");
        Console.WriteLine("=====================================");

        {
            Singleton fromPlace1 = Singleton.Instance;
            fromPlace1.CallSomeMethod("From Place 1");

            Singleton fromPlace2 = Singleton.Instance;
            fromPlace2.CallSomeMethod("From Place 2");
        }

        Console.WriteLine();
    }
}

public sealed class Singleton
{
    private static int _counter;
    private static Singleton? _instance;
    private static readonly object _instanceLock = new object();

    public static Singleton Instance
    {
        get
        {
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }

    private Singleton()
    {
        _counter++;
        Console.WriteLine($"Singleton constructor executed {_counter} time");
    }

    public void CallSomeMethod(string message)
    {
        Console.WriteLine($"SomeMethod called with this message: {message}");
    }
}

