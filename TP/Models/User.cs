using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TP.Models
{
    public class User:IdentityUser
    {
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }
  
        [Display(Name = "Company")]
        [ForeignKey("Company")]
        public int intCompany { get; set; }
    } 
}