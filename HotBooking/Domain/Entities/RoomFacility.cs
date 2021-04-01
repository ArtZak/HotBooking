using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class RoomFacility : EntityBase
    {
        public List<Room> Rooms { get; set; }       
    }
}
