using System;
using System.Collections.Generic;

public class UsernameFactory
{
    private IEnumerable<IFormatRule> Rules { get; set; }
    private IEnumerable<IValidation> Validations { get; set; }
    private string FullName  {get; set; }

    public UsernameFactory(string fullName, IEnumerable<IFormatRule> rules, IEnumerable<IValidation> validations)
    {
        this.FullName = fullName;
        this.Rules = rules;
        this.Validations = validations;
    }

    public string Create() 
    {
        foreach(var rule in Rules)
        {            
            string userName = rule.Test(SplitFullname.Get(this.FullName));
            bool isApropriated = true;
            foreach(var val in Validations)
            {
                Console.WriteLine("{0}, {1}, {2}", userName, rule.GetType().FullName, val.GetType().FullName);
                bool isValid = val.Validate(userName);
                if(!isValid) 
                {
                    Console.WriteLine("{0} filed at {1} test", userName, val.GetType().FullName);
                    isApropriated = isValid;
                }
            }            
            if(isApropriated) {
                return userName;
            } 
        }
        throw new Exception("Unable to create a username");
    }
}