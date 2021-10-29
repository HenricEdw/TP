using System;
using System.ComponentModel.DataAnnotations;

namespace TP.Models
{
    public class Booking
    {
        public int bookingID { get; set; }

        [Display(Name ="Int User")]
        public int intUser { get; set; }

        [Display(Name ="Int Room")]
        public int intRoom { get; set; }

        [Display(Name ="Start Booking ")]
        public DateTime startBooking { get; set; }

        [Display(Name ="End Booking")]
        public DateTime endBooking { get; set; }

        [Timestamp]
        [Display(Name = "Booking Time")]
        public byte[] bookingTime { get; set; }

        [Display(Name = "Room Price")]
        public double roomPrice { get; set; }

    }
}
