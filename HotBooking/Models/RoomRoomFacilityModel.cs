using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class RoomRoomFacilityModel : BaseModel
    {
        public Guid RoomId { get; set; }
        public virtual Room Room { get; set; }
        public Guid RoomFacilityId { get; set; }
        public virtual RoomFacility RoomFacility { get; set; }
    }
}
