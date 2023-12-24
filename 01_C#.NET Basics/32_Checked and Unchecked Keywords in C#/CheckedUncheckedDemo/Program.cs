namespace CheckedUncheckedDemo;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**********Max Int Value**********");
        Console.WriteLine("=================================");

        {
            Console.WriteLine(int.MaxValue);
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Adding Max Int without checked**********");
        Console.WriteLine("==================================================");

        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;

            int result = num1 + num2;
            Console.WriteLine(result);
            // As you can see it displays -2, but this is what we were not expecting.
            // What we expect is some error (overflow) or exception.
            // This is where the Checked keyword helps us to achieve and throws overflow exception.
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Adding Max Int with checked**********");
        Console.WriteLine("===============================================");

        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;

            /*
            int result = checked(num1 + num2);
            Console.WriteLine(result);
            */

            // When you run the application, you should get the following OverflowException as expected.
            // W can say that the checked keyword is used in scenarios where you want to ensure that your left hand side data type is not getting overflow
        }

        Console.WriteLine('\n' + new string('=', 70) + '\n');
        Console.WriteLine("**********Adding Max Int with unchecked**********");
        Console.WriteLine("=================================================");

        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;

            int result = unchecked(num1 + num2);
            Console.WriteLine(result);
        }
    }
}
