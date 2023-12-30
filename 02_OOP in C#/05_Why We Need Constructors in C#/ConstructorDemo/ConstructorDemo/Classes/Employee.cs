namespace ConstructorDemo.Classes;
internal class Employee
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsPermenant { get; set; }


    public Employee(int id, int age, string name, string address, bool isPermenant)
    {
        Id = id;
        Age = age;
        Name = name;
        Address = address;
        IsPermenant = isPermenant;
    }

    /// <summary>
    /// Copy constructor
    /// </summary>
    /// <param name="emp">object to be copied</param>
    public Employee(Employee emp)
    {
        Id = emp.Id;
        Age = emp.Age;
        Name = emp.Name;
        Address = emp.Address;
        IsPermenant = emp.IsPermenant;
    }

    public void Display()
    {
        Console.WriteLine($"ID:        {Id}");
        Console.WriteLine($"Name:      {Name}");
        Console.WriteLine($"Age:       {Age}");
        Console.WriteLine($"Permenant: {IsPermenant}");
        Console.WriteLine($"Address:   {Address}");
    }
}
