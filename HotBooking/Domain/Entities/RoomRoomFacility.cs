using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class RoomRoomFacility
    {
        public Guid RoomId { get; set; }
        public virtual Room Room { get; set; }
        public Guid RoomFacilityId { get; set; }
        public virtual RoomFacility RoomFacility { get; set; }
    }
}
