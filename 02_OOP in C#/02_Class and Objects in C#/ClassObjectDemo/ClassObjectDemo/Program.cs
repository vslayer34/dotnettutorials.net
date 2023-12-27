namespace ClassObjectDemo;
internal class Program
{
    static void Main(string[] args)
    {
        // Creating object of the Calculator class
        Calculator calculatorObj = new Calculator();


        // Acessing Calculator class member using Calculator class object
        int result = calculatorObj.CalculateSum(10, 20);
        Console.WriteLine(result);
    }
}


// Defining a class, blueprint or template
public class Calculator
{
    public int CalculateSum(int num1, int num2) => num1 + num2;
}
