using System;
using System.ComponentModel.DataAnnotations;

namespace TP.Models
{
    public class Room
    {
        public int roomID { get; set; }

        [Display(Name ="Room Name")]
        public string roomName { get; set; }

        [Display(Name ="Price ID")]
        public int priceID { get; set; }

    }
}
