using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Room : EntityBase
    {
        public List<RoomFacility> RoomFacilities { get; set; }

        [Required]
        public Guid HotelId { get; set; }
    }
}
