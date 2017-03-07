public class UsernameLengthValidation : IValidation
{
    public bool Validate(string userName)
    {
        int length = userName.Length;
        return length > 0 && length < 11 ? true : false;
    }
}