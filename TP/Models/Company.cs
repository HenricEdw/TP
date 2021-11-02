using System;
using System.ComponentModel.DataAnnotations;

namespace TP.Models
{
    public class Company
    {
        public int companyID { get; set; }

        [Display(Name ="Företagsnamn")]
        public string strCompanyName { get; set; }


        [Display(Name = "Företagsrabatt")]
        public int discountID { get; set; }
      
    }
}
