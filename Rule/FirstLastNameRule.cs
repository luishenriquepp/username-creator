public class FirstLastNameRule : IFormatRule
{
    public string Test(string[] fullName)
    {
        return fullName[fullName.Length - fullName.Length] + fullName[fullName.Length-1];
    }
}