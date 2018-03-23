using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class LoginController : Controller
    {        

        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
      
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View(); 
        }
        public static bool IsValidPassWord(string passwords)
        {
            
            bool validation;
            if (passwords.Length >= 8 && passwords.Any(char.IsUpper) && passwords.Any(char.IsLower))
            {
                validation = true;

            }
            else
            {
                validation = false;

            }
            return validation;
        }
         public static bool IsValidEmail(string email)
        {            
            int posat = email.IndexOf("@");
            int posdot = email.IndexOf(".");

            char firstLetter = email.First();
            char lastLetter = email.Last();

            List<char> charsToCheck = new List<char>() { '.' };
            int periodCount = email.Count(x => charsToCheck.Contains(x));
            int lastposdot = email.LastIndexOf('.');

            List<char> atsToCheck = new List<char>() { '@' };
            int atCount = email.Count(x => atsToCheck.Contains(x));

            bool validation;

            //Testing Below

            if (atCount > 1 || atCount < 1)
            {
                validation = false;
                return validation; 
            }

            if (periodCount < 1)
            {
                validation = false;
                return validation; 
            }

            if (periodCount > 1 && firstLetter != '.' && lastLetter != '.' && firstLetter != '@' && lastLetter != '@')
            {                
                if (lastposdot > posat)
                {
                    validation = true; 
                }
                validation = true;
                return validation; 
            }
            else if ( periodCount == 1 && firstLetter != '.' && lastLetter != '.' && firstLetter != '@' && lastLetter != '@')
            {
                if (posdot > posat)
                {
                    validation = true; 
                   // Console.WriteLine("Email is good.");                    
                }
                validation = true;
                return validation; 
            }
            else
            {
                //Console.WriteLine("email is bad.");
                validation = false;
                return validation; 
            }

        } 
        
        [HttpPost]
        public IActionResult ThankYou(string email, string password, CreateProfile account)
        {    
           //string account;       
           if (IsValidEmail(email) == true && IsValidPassWord(password) == true)
            {
             Repository.AddAccount(account);
                return View("AccountCreated"); 
               
                //Console.WriteLine("Email is good");
            }
            else
            {
                return View("AccountFailed");
                //Console.WriteLine("Email is bad");
            }      
                      
            //return View(); 
        }
        
        public IActionResult AccountCreated()
        {
            return View(); 
        }
        
        public IActionResult AccountFailed()
        {
            return View(); 
        }        
        
        [HttpPost]
        public ViewResult LoginSuccess(string email, string password, CreateProfile createprofile)
        {
            //if user has an account
                //return login success
            //else
                //return loginFailed

            email = createprofile.Email; 
            password = createprofile.PassWord; 
            bool account = false; 
            
            foreach (var ac in Repository.Accounts)
            {
                if(ac.Email == email && ac.PassWord == password)
                {
                    account = true; 
                }
            }
            if(account == true)
            {
                return View();
            }
            else
            {
                return View("LoginFail"); 
            }


            
           
                
                // if (Repository.accounts.Contains(email) && Repository.accounts.Contains(password))
                // {
                //     return View();
                // }
                // else
                // {
                //     return View("LoginFail");
                // }

            // if ()
            // {
            //     return View("LoginSuccess");
            // }
            // else
            // {
            //     return View("LoginFail");
            // }
            //return View(Repository.Accounts); 
            
        }
        [HttpPost]
        public IActionResult LoginFail()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Thanks()
        {
            return View(); 
        }
        public IActionResult ViewAccount()
        {
            return View(Repository.Accounts);
        }
        // public static bool CustHasAccount(string email, string password, Repository Accounts )
        // {
            
        //    // Repository.Accounts.Contains(email);
        //    List<string> account = new List<string>();
        //     //Repository.Accounts.Contains(email);
        //     //string account = Repository.Accounts;
        //     bool hasAccount;
        //     if (account.Contains(email))
        //     {
        //         hasAccount = true; 
        //     }
        //     else
        //     {
        //         hasAccount = false; 
        //     }
        //     return hasAccount; 
        // }
       // public IActionResult Thanks()
        //{

            // if(ModelState.IsValid)
            // {
            //     Repository.AddAccount(account);
            //     return View("Thanks", account);
            // }
            // else{
            //     return View("LoginFail");
            // }
        //}
       
            
        
            
        

    
    }
}
