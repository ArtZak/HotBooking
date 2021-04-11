using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Room : EntityBase
    {
        [Required]
        public Guid HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<RoomFacility> RoomFacilities { get; set; }
        public virtual ICollection<RoomRoomFacility> RoomRoomFacilities { get; set; }
    }
}
