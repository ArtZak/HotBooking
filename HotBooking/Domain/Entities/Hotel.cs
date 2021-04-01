using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Hotel : EntityBase
    {
        [Display(Name = "Stars")]
        public byte Stars { get; set; }

        [Display(Name = "Distance to center")]
        public float DistanceToCenter { get; set; }

        [Display(Name = "Food")]
        public string Food { get; set; }

        [Display(Name = "Review rating")]
        public float ReviewRating { get; set; }
        public bool IsFavorite { get; set; } = false;

        public List<Room> Rooms { get; set; }
        public List<HotelFacility> HotelFacilities { get; set; }

        [Required]
        public Guid CityId { get; set; }
    }
}
