namespace DestructorDemo;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********Destructor Example**********");
        Console.WriteLine("======================================");

        {
            DestructorExample example1 = new DestructorExample();
            DestructorExample example2 = new DestructorExample();

            // Making example1 eligable for garbage collection
            example1 = null;

            GC.Collect();
        }

        Console.ReadKey();
    }
}


class DestructorExample
{
    public DestructorExample()
    {
        Console.WriteLine("Constructor object created");
    }

    ~DestructorExample()
    {
        string type = GetType().Name;
        Console.WriteLine($"object {type} is destroyed");
    }
}