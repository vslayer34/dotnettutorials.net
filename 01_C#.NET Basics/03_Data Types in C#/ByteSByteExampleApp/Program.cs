using System;

namespace ByteSByteExampleApp;

class Program
{
    private static void Main(string[] args)
    {
        byte b1 = 66;
        // you can't store negative values using byte data type
        // this statement would give compile runtime error
        // byte negativeB = -100;

        // The following statment would give compile runtime error
        // the maximum value you can store in a byte data type is 255
        // byte aboveMaxByte = 256;

        Console.WriteLine($"Decimal: {b1}");
        Console.WriteLine($"ASCII equivalent character of {b1} is: {Convert.ToChar(b1)}");
        Console.WriteLine($"Byte minimum value: {Byte.MinValue}");
        Console.WriteLine($"Byte maximum value: {Byte.MaxValue}");
        Console.WriteLine($"Byte size: {sizeof(Byte)} Byte");


        sbyte sb1 = 66;
        // We can store negative numberes using sbyte data type
        // The following statement won't give compile runtime error
        sbyte sb2 = -100;

        // The following statement will give a compile runtime error
        // sbyte sb3 = 128;
        // The maximum value we can store in a sbyte variable is: 128

        // The following statement will give compile runtime error
        // sbyte sb4 = -129;
        // The minimumvalue you can store in a sbyte variable is -128

        Console.WriteLine();
        Console.WriteLine(new string('-', 100));
        Console.WriteLine();

        Console.WriteLine($"Decimal: {sb1}");
        Console.WriteLine($"ASCII equivalent character of {b1} is: {Convert.ToChar(b1)}");
        Console.WriteLine($"sByte minimum value: {SByte.MinValue}");
        Console.WriteLine($"sByte maximum value: {SByte.MaxValue}");
        Console.WriteLine($"sByte size: {sizeof(SByte)} Byte");

        Console.ReadKey();
    }
}