using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var usernames = new List<string> 
            {
                "LuisPaim",
                "HenriquePaim",
                "LPaim"
            };

            UsernameFactory fac = new UsernameFactory("Luis",
            new List<IFormatRule> { new FirstLastNameRule(), new FirstTwoLetterLastNameRule() } ,
            new List<IValidation> { new UsernameLengthValidation(), new UsernameExistsValidation(usernames) });
            
            try 
            {
                var username = fac.Create();
                Console.WriteLine("{0} is the current username", username);
            } 
            catch (Exception e)
            {
                Console.WriteLine("Error -> {0}", e.Message);
            }            
        }
    }
}
