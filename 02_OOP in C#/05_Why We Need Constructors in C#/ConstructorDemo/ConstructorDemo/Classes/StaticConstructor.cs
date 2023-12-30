namespace ConstructorDemo.Classes;
internal class StaticConstructor
{
    public int Number { get; set; }
    public static int StaticNumber { get; set; }


    /// <summary>
    /// Default Explicit Constructor
    /// </summary>
    public StaticConstructor()
    {
        Console.WriteLine("Default Constructor Executed");
        Number = 100;
    }

    /// <summary>
    /// Static COnstructor
    /// </summary>
    static StaticConstructor()
    {
        Console.WriteLine("Static constructor executed");
        StaticNumber = 100;
    }

    public void Increment()
    {
        Number++;
        StaticNumber++;
    }

    public void Display()
    {
        Console.WriteLine($"Value of Number:       {Number}");
        Console.WriteLine($"Value of StaticNumber: {StaticNumber}");
    }
}
