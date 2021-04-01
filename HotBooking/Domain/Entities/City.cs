using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class City : EntityBase
    {
        public List<Hotel> Hotels { get; set; }

        public bool IsFavorite { get; set; } = false;

        [Required]
        public Guid CountryId { get; set; }      
    }
}
