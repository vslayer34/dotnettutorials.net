namespace AssemblyOne;
public class AssemblyOneClass1
{
    private int _id;
    public int publicId;
    protected int protectedId;

    public void Display()
    {
        // Private Member Accessible with the Containing Type only Where they are created
        // They are available only within that type
        Console.WriteLine(_id);

        // Public Members Accessible with the Containing Type where they are created
        Console.WriteLine((publicId));

        // protected Members Accessible with the Containing Type where they are created
        Console.WriteLine(protectedId);
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
    }
}