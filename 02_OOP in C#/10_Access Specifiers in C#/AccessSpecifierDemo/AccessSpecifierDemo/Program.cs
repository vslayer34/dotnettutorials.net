using AssemblyOne;


namespace AccessSpecifierDemo;
internal class Program
{
    static void Main(string[] args)
    {
        
    }
}


public class AnotherAssemblyClass1 : AssemblyOneClass1
{
    public void Display4()
    {
        // You cannot access the Private Member from the Derived Class from Other Assemblies
        // Console.WriteLine(_id);              // Compile error

        // We Can access the public Member from Derived Classes from Other Assemblies
        Console.WriteLine(publicId);
    }
}


public class AnotherAssemblyClass2
{
    public void Display33()
    {
        // You cannot access the Private Member from the Non-Derived Classes from Other Assemblies
        AssemblyOneClass1 obj = new();

        // Console.WriteLine(obj._id);          // Compile error

        // We Can access the public Member from Non-Derived Classes from Other Assemblies
        Console.WriteLine(obj.publicId);
    }
}