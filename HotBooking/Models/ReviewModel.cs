using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class ReviewModel
    {
        public ReviewModel() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        [Required]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public int Rating { get; set; }

        [Required]
        public string Text { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
