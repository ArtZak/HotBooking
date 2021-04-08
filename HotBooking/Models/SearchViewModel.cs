using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class SearchViewModel
    {
        [Required]
        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [Display(Name ="Arrival date")]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Date of departure")]
        public DateTime DateOfDeparture { get; set; }

        [Display(Name = "Adults")]
        public int Adults { get; set; }
        
        [Display(Name = "Children")]
        public int Children { get; set; }

        [Display(Name = "Rooms")]
        public int Rooms { get; set; }
    }
}
