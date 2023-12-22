namespace PropertyDemo.classes;
internal class Employee
{
    // Private data members
    private int _id;
    private string _name = string.Empty;
    private int _age;
    private string _address = string.Empty;

    // public properties
    public int ID
    {
        get =>  _id; 
        set
        {
            if ( _id < 0 )
            {
                throw new Exception("ID value should always be greater than zero");
            }

            _id = value;
        }
    }
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(_name))
            {
                throw new Exception("Name field can't be null or empty");
            }
        }
    }
    public int Age { get => _age; set => _age = value; }
    public string Address { get => _address; set => _address = value; }
}
