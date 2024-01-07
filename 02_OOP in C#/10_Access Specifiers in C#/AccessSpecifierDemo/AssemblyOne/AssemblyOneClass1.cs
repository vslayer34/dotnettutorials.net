namespace AssemblyOne;
public class AssemblyOneClass1
{
    private int _id;
    public int publicId;
    protected int protectedId;
    internal int internalId;
    protected internal int protectedInternalId;
    private protected int privateProtectedId;

    public void Display()
    {
        // Private Member Accessible with the Containing Type only Where they are created
        // They are available only within that type
        Console.WriteLine(_id);

        // Public Members Accessible with the Containing Type where they are created
        Console.WriteLine((publicId));

        // protected Members Accessible with the Containing Type where they are created
        Console.WriteLine(protectedId);

        // Internal Members Accessible with the Containing Type where they are created
        Console.WriteLine(internalId);

        // Protected internal Members Accessible with the Containing Type where they are created
        Console.WriteLine(protectedInternalId);

        // Private Protected Members Accessible with the Containing Type where they are created
        Console.WriteLine(privateProtectedId);
    }
}

public class AssemblyOneClass2 : AssemblyOneClass1
{
    public void Display2()
    {
        // You cannot access the Private Member from the Derived Class within the Same Assembly

        // Console.WriteLine(_id);     // Compile error

        // We Can access public Members from Derived Class within the Same Assembly
        Console.WriteLine(publicId);

        // We Can access protected Member from Derived Classes within the Same Assembly
        Console.WriteLine(protectedId);

        // We can access internal Members from Derived Classes within the Same Assembly
        Console.WriteLine(internalId);

        // We can access protected internal Member from Derived Classes within the Same Assembly
        Console.WriteLine(protectedInternalId);

        // We can access Private Protected Member from Derived Classes within the Same Assembly
        Console.WriteLine(privateProtectedId);
    }
}


public class AssemblyOneClass3
{
    public void Display3()
    {
        // You cannot access the Private Member from the Non-Derived Classes within the Same Assembly
        
        AssemblyOneClass1 obj = new();
        // Console.WriteLine(obj._id);                      // Compile error

        // We Can access public Members from Non-Derived Classes within the Same Assembly
        Console.WriteLine(obj.publicId);

        // We Cannot access protected Member from Non-Derived Classes within the Same Assembly
        // Console.WriteLine(obj.protectedId);              // Compile error

        // We can access internal Members from Non-Derived Classes within the Same Assembly
        Console.WriteLine(obj.internalId);

        // We can access protected internal Member from Non-Derived Classes within the Same Assembly
        Console.WriteLine(obj.protectedInternalId);

        // We cannot access Private Protected Member from Non-Derived Classes within the Same Assembly
        // Console.WriteLine(obj.privateProtectedId);       // Compile error
    }
}