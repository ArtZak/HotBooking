using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class HotelFacility : EntityBase
    {
        public List<Hotel> Hotels { get; set; }
    }   
}
