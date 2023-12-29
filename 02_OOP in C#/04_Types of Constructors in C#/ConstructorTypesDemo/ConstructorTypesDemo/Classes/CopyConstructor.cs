namespace ConstructorTypesDemo.Classes;
internal class CopyConstructor
{
    public int Number {  get; set; }

    public CopyConstructor(int number)
    {
        Number = number;
    }

    public CopyConstructor(CopyConstructor copy)
    {
        Number = copy.Number;
    }

    public void DisplayNumber()
    {
        Console.WriteLine($"Value of Number is: {Number}");
    }
}
