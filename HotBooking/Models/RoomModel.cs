using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class RoomModel : BaseModel
    {
        [Required]
        public decimal PricePerNight { get; set; }
        [Required]
        public int Visitors { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public Guid HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<RoomFacility> RoomFacilities { get; set; }
        public virtual ICollection<RoomRoomFacility> RoomRoomFacilities { get; set; }
    }
}
