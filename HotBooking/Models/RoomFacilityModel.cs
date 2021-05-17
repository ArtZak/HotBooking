using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class RoomFacilityModel : BaseModel
    {
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<RoomRoomFacility> RoomRoomFacilities { get; set; }
    }
}
