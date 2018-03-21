using System.Collections.Generic;

namespace Midterm.Models
{
    public static class Repository
    {
        private static List<CreateProfile> accounts = new List<CreateProfile>();

        public static IEnumerable<CreateProfile> Accounts {
            get{
                return accounts;
            }
        }

        public static void AddAccount(CreateProfile account){
            accounts.Add(account);
        }
    }
}