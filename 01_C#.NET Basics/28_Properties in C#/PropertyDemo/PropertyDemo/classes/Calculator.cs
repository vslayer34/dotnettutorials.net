namespace PropertyDemo.classes;
internal class Calculator
{
    private int _num1;
    private int _num2;
    private int _result;

    // Write only properties
    public int Number1 { set => _num1 = value; }
    public int Number2 { set => _num2 = value; }

    // Read only property
    public int Result { get => _result; }

    public void Add()
    {
        _result = _num1 + _num2;
    }

    public void Subtract()
    {
        _result = _num1 - _num2;
    }

    public void Multiply()
    {
        _result = _num1 * _num2;
    }

    public void Divide()
    {
        _result = _num1 / _num2;
    }
}
