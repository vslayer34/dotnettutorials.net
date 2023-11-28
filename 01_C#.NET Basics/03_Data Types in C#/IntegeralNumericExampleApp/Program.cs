using System;


namespace IntegeralNumericExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        // Int16 num1 = 123;
        short num1 = 123;

        // Int32 num2 = 456;
        int num2 = 456;

        // Int64 num3 = 789;
        long num3 = 789;


        Console.WriteLine($"short/Int16 minimum value: {short.MinValue}".PadRight(50) + $"short/Int16 minimum value: {short.MaxValue}");
        Console.WriteLine($"short size: {sizeof(short)} bytes");
        
        Console.WriteLine($"int/Int32 minimum value: {int.MinValue}".PadRight(50) + $"int/Int32 minimum value: {int.MaxValue}");
        Console.WriteLine($"int size: {sizeof(int)} bytes");
        
        Console.WriteLine($"long/Int64 minimum value: {long.MinValue}".PadRight(50) + $"long/Int64 minimum value: {long.MaxValue}");
        Console.WriteLine($"long size: {sizeof(long)} bytes");

        Console.WriteLine($"");
        Console.WriteLine(new string('-', 100));
        Console.WriteLine($"");


        // Int16 unum1 = 123;
        ushort unum1 = 123;

        // Int32 unum2 = 456;
        uint unum2 = 456;

        // Int64 unum3 = 789;
        ulong unum3 = 789;


        Console.WriteLine($"ushort/uInt16 minimum value: {ushort.MinValue}".PadRight(50) + $"ushort/uInt16 minimum value: {ushort.MaxValue}");
        Console.WriteLine($"ushort size: {sizeof(ushort)} bytes");
        
        Console.WriteLine($"uint/uInt32 minimum value: {uint.MinValue}".PadRight(50) + $"uint/uInt32 minimum value: {uint.MaxValue}");
        Console.WriteLine($"uint size: {sizeof(uint)} bytes");
        
        Console.WriteLine($"ulong/uInt64 minimum value: {ulong.MinValue}".PadRight(50) + $"ulong/uInt64 minimum value: {ulong.MaxValue}");
        Console.WriteLine($"ulong size: {sizeof(ulong)} bytes");        
        
        Console.ReadKey();
    }
}