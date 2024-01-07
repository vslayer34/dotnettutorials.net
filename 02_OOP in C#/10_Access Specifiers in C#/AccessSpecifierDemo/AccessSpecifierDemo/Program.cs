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
        // Console.WriteLine(_id);                                  // Compile error

        // We Can access the public Member from Derived Classes from Other Assemblies
        Console.WriteLine(publicId);

        // We cannot access the Internal Member from Derived Classes from Other Assemblies
        // Console.WriteLine(internalId);                           // Compile error

        // We can access the protected internal Members from Derived Classes from Other Assemblies
        Console.WriteLine(protectedInternalId);

        // We cannot access Private Protected Member from Derived Classes from Other Assemblies
        // Console.WriteLine(privateProtectedId);                   // Compile error
    }
}


public class AnotherAssemblyClass2
{
    public void Display33()
    {
        // You cannot access the Private Member from the Non-Derived Classes from Other Assemblies
        AssemblyOneClass1 obj = new();

        // Console.WriteLine(obj._id);                              // Compile error

        // We Can access the public Member from Non-Derived Classes from Other Assemblies
        Console.WriteLine(obj.publicId);

        // We cannot access internal Member from Non-Derived Classes from Other Assemblies
        // Console.WriteLine(obj.internalId);                       // Compile error

        // We cannot access protected internal Members from Non-Derived Classes from Other Assemblies
        // Console.WriteLine(obj.internalProtectedId);              // Compile error

        // We cannot access Private Protected Member from Non-Derived Classes from Other Assemblies
        // Console.WriteLine(obj.privateProtectedId);               // Compile error
    }
}