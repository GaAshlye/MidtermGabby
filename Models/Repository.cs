using System.Collections.Generic;

namespace Midterm.Models
{
    public class Repository
    {
        public static List<CreateProfile> accounts = new List<CreateProfile>()
        {
            new CreateProfile("test@test.com","123456Aa")
            
            
        }; //changed from private static to public static 

        public static IEnumerable<CreateProfile> Accounts {
            get{
                return accounts;
            }
        }
        

        public static void AddAccount(CreateProfile account)
        {
            
            accounts.Add(account);
           // accounts.Add(account);
        }
    }
}