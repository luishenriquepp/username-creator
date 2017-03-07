public class FirstTwoLetterLastNameRule : IFormatRule
{
    public string Test(string fullName)
    {
        string[] spliced = fullName.Split(' ');
        string username = spliced[spliced.Length - spliced.Length].Substring(0, 1) + spliced[spliced.Length-1];
        return username;
    }
}