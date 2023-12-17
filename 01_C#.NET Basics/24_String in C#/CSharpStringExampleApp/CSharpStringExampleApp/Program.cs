using System.Diagnostics;
using System.Text;

namespace CSharpStringExampleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********Strings are Immutable Example**********");
        Console.WriteLine("=================================================");

        // new object created each time
        {
            string str = string.Empty;

            Console.WriteLine("Loop Started"); ;
            Stopwatch stopWatch = new();

            stopWatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = Guid.NewGuid().ToString();
            }
            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine($"Loop execution time in ms is: {stopWatch.ElapsedMilliseconds} ms");
        }

        Console.WriteLine('\n' + new String('=', 100) + '\n');
        Console.WriteLine("**********Ints are Mutable Example**********");
        Console.WriteLine("============================================");

        {
            int ctr = 0;
            Console.WriteLine("Loop started");
            Stopwatch stopWatch = new();

            stopWatch.Start();
            for (int i = 0; i < 30000000;  i++)
            {
                ctr++;
            }

            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine($"Loop execution time in ms is: {stopWatch.ElapsedMilliseconds} ms");
        }

        Console.WriteLine('\n' + new String('=', 100) + '\n');
        Console.WriteLine("**********Assigning the Same Value to String Example**********");
        Console.WriteLine("==============================================================");

        // assigning the same value over and over again doesn't create a new object
        {
            string str = string.Empty;

            Console.WriteLine("Loop Started"); ;
            Stopwatch stopWatch = new();

            stopWatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = "Rana";
            }
            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine($"Loop execution time in ms is: {stopWatch.ElapsedMilliseconds} ms");
        }

        Console.WriteLine('\n' + new String('=', 100) + '\n');
        Console.WriteLine("**********String Contcatenation Example**********");
        Console.WriteLine("=================================================");

        {
            string str = string.Empty;
            Console.WriteLine("Loop started");
            Stopwatch stopWatch = new();

            stopWatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                str += "Rana";
            }

            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine($"Loop execution time in ms is: {stopWatch.ElapsedMilliseconds} ms");
        }

        Console.WriteLine('\n' + new String('=', 100) + '\n');
        Console.WriteLine("**********String Builder Example**********");
        Console.WriteLine("==========================================");

        {
            StringBuilder stringBuilder = new();
            Console.WriteLine("Loop started");
            Stopwatch stopWatch = new();
            
            stopWatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                stringBuilder.Append("Rana");
            }

            stopWatch.Stop();
            Console.WriteLine("Loop ended");
            Console.WriteLine($"Loop execution time in ms is: {stopWatch.ElapsedMilliseconds} ms");
        }

        Console.ReadKey();
    }
}
