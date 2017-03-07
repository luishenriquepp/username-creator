public class FirstLastNameRule : IFormatRule
{
    public string Test(string fullName)
    {
        string[] spliced = fullName.Split(' ');
        string username = spliced[spliced.Length - spliced.Length] + spliced[spliced.Length-1];
        return username;
    }
}