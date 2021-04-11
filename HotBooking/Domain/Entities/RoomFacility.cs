using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class RoomFacility : EntityBase
    {
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<RoomRoomFacility> RoomRoomFacilities { get; set; }
    }
}
