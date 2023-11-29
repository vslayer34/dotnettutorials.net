using System;


namespace NonCompatibleTypeConversionExampleApp;
class Program
{
    private static void Main(string[] args)
    {
        string str = "100";
        // int i1 = (int) str;                     // Compile error: Can't convert string to int

        // Helper Conversion Methods
        int i1 = Convert.ToInt32(str);      // Converting string to integer

        double d = 123.45;
        int i2 = Convert.ToInt32(d);        // Converting double to integer

        float f = 45.678f;
        string str2 = Convert.ToString(f);  // Converting float to string

        Console.WriteLine($"Original value str: {str} and converted valie i1: {i1}");
        Console.WriteLine($"Original value d: {d} and converted value i2: {i2}");
        Console.WriteLine($"Original value f: {f} and converted value str2: {str2}");

        Console.WriteLine();
        Console.WriteLine("********************Parsing********************");
        Console.WriteLine("===============================================");
        Console.WriteLine();

        {
            string str11 = "100";
            // Converting a string to int type
            int i = int.Parse(str11);
            Console.WriteLine($"Original string value: {str11} and the converted integer value: {i}");

            string str22 = "TRUE";
            // Converting a string to a boolean type
            bool b = bool.Parse(str22);
            Console.WriteLine($"Original string value: {str22} and the converted integer value: {b}");
        }

        Console.WriteLine();
        Console.WriteLine("********************TryParse********************");
        Console.WriteLine("================================================");
        Console.WriteLine();

        {
            string str11 = "100";
            bool isConverted11 = int.TryParse(str11, out int i11);

            if (isConverted11)
            {
                Console.WriteLine($"Original string value str11: {str11} and the converted integer value i11: {i11}");
            }
            else
            {
                Console.WriteLine($"TryParse() failed to convert that string \"{str11}\" to an integer");
            }

            string str22 = "Rana";
            bool isConverted22 = int.TryParse(str22, out int i22);

            if (isConverted22)
            {
                Console.WriteLine($"Original string value str22: {str22} and the converted integer value i22: {i22}");
            }
            else
            {
                Console.WriteLine($"TryParse() failed to convert that string \"{str22}\" to an integer");
            }
        }

        Console.ReadKey();
    }
}
