using StaticKeywordDemoApp.Utilities;

namespace StaticKeywordDemoApp;

internal class Customer
{
    public string CustomerCode { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;

    private string _machineName = string.Empty;

    public Customer()
    {
        _machineName = CommonTask.GetComputerName();
    }

    public void Insert()
    {
        if (!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
        {
            //Insert the data
        }
    }
}
