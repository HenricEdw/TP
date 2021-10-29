using System;
using System.ComponentModel.DataAnnotations;

namespace TP.Models
{
    public class Company
    {
        public int companyID { get; set; }

        [Display(Name ="Company Name")]
        public string strCompanyName { get; set; }
        public int discountID { get; set; }
      
    }
}
