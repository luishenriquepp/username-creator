using System.Collections.Generic;
using System.Linq;

public class UsernameExistsValidation : IValidation
{
    private ICollection<string> Usernames { get; set; }

    public UsernameExistsValidation(ICollection<string> usernames)
    {
        this.Usernames = usernames;
    }
    
    public bool Validate(string userName)
    {
        var alreadyExists = Usernames.Where(t => t.Equals(userName)).Any();
        return alreadyExists ? false : true;
    }
}