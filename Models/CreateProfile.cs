using System; 
using System.Collections.Generic;
using System.Diagnostics; 
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using Midterm.Models;
using System.ComponentModel.DataAnnotations;
//using System.Collections.Generic;

namespace Midterm.Models
{
     public class CreateProfile
     {
          //[Required(ErrorMessage = "Please enter your name")]
        // public string Name{get; set;}

        public CreateProfile(string Email, string PassWord){
            this.Email = Email; 
            this.PassWord = PassWord; 
        }
        public CreateProfile(){}
       
        [Required(ErrorMessage = "Please enter your name")]
         public string Email{get;set;}

        [Required(ErrorMessage = "Please enter your password")]     
         public string PassWord{get;set;}
     }
    //  public static class Repository
    // {
    //     private static List<CreateProfile> accounts = new List<CreateProfile>();

    //     public static IEnumerable<CreateProfile> Accounts {
    //         get{
    //             return accounts;
    //         }
    //     }

    //     public static void AddAccount(CreateProfile account){
    //         accounts.Add(account);
    //     }
    // }
    
}