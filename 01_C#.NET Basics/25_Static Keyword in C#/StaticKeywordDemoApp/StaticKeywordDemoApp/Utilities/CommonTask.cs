namespace StaticKeywordDemoApp.Utilities;

internal static class CommonTask
{
    public static bool IsEmpty(string value) => value.Length > 0 ? true : false;
    public static string GetComputerName() => System.Environment.MachineName;
}
