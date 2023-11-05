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

            // SomeMethod(name);
            SomeMthod2();

            Console.WriteLine("Main Method Ended.....");
            Console.ReadKey();
        }


        public async static void SomeMethod(string name)
        {
            Console.WriteLine("SomeMethod Started...");
            try
            {
                string greetingMessage = await Greetings(name);
                Console.WriteLine();
                Console.WriteLine($"{greetingMessage}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Error occured: {ex.Message}");
            }
            Console.WriteLine("SomeMethod Ended...");
        }


        public static async Task<string> Greetings(string name)
        {
            string message = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5068/");

                HttpResponseMessage response = await client.GetAsync($"api/greetings2/{name}");
                response.EnsureSuccessStatusCode();

                message = await response.Content.ReadAsStringAsync();
            }

            return message;
        }

        //-----------------------------------------------------------------------------------------
        //---------------------------------return complex types------------------------------------

        private static async void SomeMthod2()
        {
            Employee emp = await GetEmployeeDetails();
            Console.WriteLine($"ID: {emp.Id.ToString().PadRight(20)}Name: {emp.Name.PadRight(20)}\tSalary: {emp.Salary}");
        }

        private static async Task<Employee> GetEmployeeDetails()
        {
            Employee employee = new()
            {
                Id = 101,
                Name = "Jamaes",
                Salary = 10000m
            };

            return employee;
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set ;} = string.Empty;
        public decimal Salary { get; set; }
    }
}