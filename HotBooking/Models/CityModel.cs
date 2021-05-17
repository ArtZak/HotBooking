using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class CityModel : BaseModel
    {
        public bool IsFavorite { get; set; } = false;

        [Required]
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
