namespace ToStringVSConvertToStringDemo;
class Program
{
    private static void Main(string[] args)
    {
        // Both these methods are used to convert a value to a string. The difference is Convert.
        // ToString() method handles null whereas the ToString() doesn’t handle null in C#.

        Console.WriteLine("**********ToString() doesn't handle nulls**********");
        Console.WriteLine("===================================================");
        {
            Customer c1 = null;
            /*c1.ToString();*/
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Convert.ToString() do handle nulls**********");
        Console.WriteLine("======================================================");

        {
            Customer? c1 = null;
            Convert.ToString(c1);

            string? name = null;
            Convert.ToString(name);

            // The program runs and doesn't throw an exception
        }

        Console.ReadKey();
    }
}


public class Customer
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}