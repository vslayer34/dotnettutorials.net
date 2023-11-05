using System.Xml.Linq;

namespace ConsoleTestAPIApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started.....");
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            SomeMethod(name);

            Console.WriteLine("Main Method Ended.....");
            Console.ReadKey();
        }


        public async static void SomeMethod(string name)
        {
            Console.WriteLine("SomeMethod Started...");
            string greetingMessage = await Greetings(name);

            Console.WriteLine();
            Console.WriteLine($"{greetingMessage}");
            Console.WriteLine("SomeMethod Ended...");
        }


        public static async Task<string> Greetings(string name)
        {
            string message = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5068/");

                HttpResponseMessage response = await client.GetAsync($"api/greetings/{name}");
                message = await response.Content.ReadAsStringAsync();
            }

            return message;
        }
    }
}