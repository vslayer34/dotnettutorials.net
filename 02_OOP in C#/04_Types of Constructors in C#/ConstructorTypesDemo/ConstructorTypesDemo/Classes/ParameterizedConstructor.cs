namespace ConstructorTypesDemo.Classes;
internal class ParameterizedConstructor
{
    public int Number { get; set; }

    public ParameterizedConstructor(int i)
    {
        Number = i;
        Console.WriteLine($"Paramaterized Constrcuctor is called: {i}");
    }

    public void DisplayNumber()
    {
        Console.WriteLine($"Value of Number is: {Number}");
    }
}
