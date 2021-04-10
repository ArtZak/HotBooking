using Microsoft.AspNetCore.Identity;
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
        public virtual Hotel Hotel { get; set; }
        public Guid UserId { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
