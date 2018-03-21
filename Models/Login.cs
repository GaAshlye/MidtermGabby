using System; 
using System.Collections.Generic;
using System.Diagnostics; 
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using Midterm.Models;
using System.ComponentModel.DataAnnotations;

namespace Midterm.Models
{
    public class Login
    {
        [EmailAddress]
        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email{get; set;}   

        [Required(ErrorMessage = "Please enter your password")]     
        public string PassWord{get; set;}
    }
}