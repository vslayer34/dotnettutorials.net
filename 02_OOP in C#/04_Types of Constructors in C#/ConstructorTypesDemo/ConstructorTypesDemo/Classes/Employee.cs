namespace ConstructorTypesDemo.Classes;
internal class Employee
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsPermanent { get; set; }


    public Employee()
    {
        Id = 100;
        Age = 30;
        Name = "Rana";
        Address = "Loran";
        IsPermanent = true;
    }


    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID:      {Id}");
        Console.WriteLine($"Employee Name:    {Name}");
        Console.WriteLine($"Employee Age:     {Age}");
        Console.WriteLine($"Employee Address: {Address}");
        Console.WriteLine($"is permenant:     {IsPermanent}");
    }
}
