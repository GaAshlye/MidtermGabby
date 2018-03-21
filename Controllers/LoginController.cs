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
        [HttpPost]
        public IActionResult ThankYou()
        {
            return View(); 
        }
        // public IActionResult ThankYou(CreateProfile accounts)
        // {
        //     if(accounts.Name == "")
        //     {
        //         Console.WriteLine("Please enter your name.");

        //     }
        //     elseif(accounts.Email)

        //     // if(ModelState.IsValid)
        //     // {
        //     //     Repository.AddAccount(accounts);
        //     //     return View("ThankYou", accounts);
        //     // }
        //     // else
        //     // {
        //     //     //return error page, one or more fields was entered incorrectly, please try again
        //     //     return View("LoginFail");
        //     // }
            
        // }
        //   public IActionResult ThankYou()
        // {
        //     return View();
            
        // }
        [HttpPost]
        public IActionResult LoginSuccess()
        {
            return View();
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
        // public IActionResult Thanks()
        // {
        //     if(ModelState.IsValid)
        //     {
        //         Repository.AddAccount(account);
        //         return View("Thanks", account);
        //     }
        //     else{
        //         return View("LoginFail");
        //     }
        // }
            
        

    
    }
}
