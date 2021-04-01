using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Review : EntityBase
    {
        [Required]
        public Guid HotelId { get; set; }
    }
}
