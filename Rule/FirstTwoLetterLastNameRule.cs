public class FirstTwoLetterLastNameRule : IFormatRule
{
    public string Test(string[] fullName)
    {
        return fullName[fullName.Length - fullName.Length].Substring(0, 1) + fullName[fullName.Length-1];
    }
}