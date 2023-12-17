using StaticKeywordDemoApp.Utilities;

namespace StaticKeywordDemoApp;

internal class CountryMaster
{
    public string CountryCode { get; set; } = string.Empty;
    public string CountryName { get; set; } = string.Empty;

    private string _computerName = string.Empty;

    public void Insert()
    {
        if (!CommonTask.IsEmpty(CountryCode) && !CommonTask.IsEmpty(CountryName))
        {
            //Logic to Insert the Country Details into the Database
            //ComputerName property tells from which computer the Record is being Inserted
        }
    }

    private string ComputerName { get => _computerName = CommonTask.GetComputerName(); }
}
