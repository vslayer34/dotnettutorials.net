namespace EqualMethodOperatorDemo;

public enum Direction
{
    East,
    Weast,
    North,
    South
}

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Equal and == in Value Types**********");
        Console.WriteLine("===============================================");

        {
            int num1 = 10;
            int num2 = 10;

            Console.WriteLine($"num1 == num2:      {num1 == num2}");
            Console.WriteLine($"num1.Equals(num2): {num1.Equals(num2)}");
        }

        Console.WriteLine('\n' + new string('=', count: 70) + '\n');
        Console.WriteLine("**********Equal and == in enums**********");
        Console.WriteLine("=========================================");

        {
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;

            Console.WriteLine($"direction1 == direction2:      {direction1 == direction2}");
            Console.WriteLine($"direction1.Equals(direction2): {direction1.Equals(direction2)}");
        }

        Console.WriteLine('\n' + new string('=', count: 70) + '\n');
        Console.WriteLine("**********Equal and == reference equality**********");
        Console.WriteLine("===================================================");

        {
            Customer c1 = new()
            {
                FirstName = "Omar",
                LastName = "Osama"
            };

            Customer c2 = c1;

            Console.WriteLine($"c1 == c2:      {c1 == c2}");
            Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}");
        }

        Console.WriteLine('\n' + new string('=', count: 70) + '\n');
        Console.WriteLine("**********Default Equals for Different Objects Same Value**********");
        Console.WriteLine("===================================================================");

        {
            Customer c1 = new()
            {
                FirstName = "Azza",
                LastName = "Zoe"
            };

            Customer c2 = new()
            {
                FirstName = "Azza",
                LastName = "Zoe"
            };

            Console.WriteLine($"c1 == c2:      {c1 == c2}");
            Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}");
        }

        Console.WriteLine('\n' + new string('=', count: 70) + '\n');
        Console.WriteLine("**********Override Equals Method to Check for Values**********");
        Console.WriteLine("==============================================================");

        {
            ModifiedCustomer c1 = new()
            {
                FirstName = "Azza",
                LastName = "Zoe"
            };

            ModifiedCustomer c2 = new()
            {
                FirstName = "Azza",
                LastName = "Zoe"
            };

            int hashcode1 = c1.GetHashCode();
            int hashcode2 = c2.GetHashCode();

            Console.WriteLine($"c1.GetHashCode == c2.GetHashCode: {hashcode1 == hashcode2}");
            Console.WriteLine($"c1 == c2:                         {c1 == c2}");
            Console.WriteLine($"c1.Equals(c2):                    {c1.Equals(c2)}");
        }

        Console.ReadKey();
    }
}

public class Customer
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

public class ModifiedCustomer
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not ModifiedCustomer)
        {
            return false;
        }
        else
        {
            var otherCustomer = obj as ModifiedCustomer;
            return this.FirstName == otherCustomer?.FirstName
                && this.LastName == otherCustomer?.LastName;
        }
    }

    // Overriding the GetHashCode method
    // GetHashCode method generates hashcode for the current object
    public override int GetHashCode()
    {
        // Performing BIT wise OR Operation on the generated hashcode values
        // If the corresponding bits are different, it gives 1.
        // If the corresponding bits are the same, it gives 0.
        return FirstName.GetHashCode() ^ LastName.GetHashCode();
    }
}