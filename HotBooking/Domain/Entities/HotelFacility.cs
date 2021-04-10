using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class HotelFacility : EntityBase
    {
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<HotelHotelFacility> HotelHotelFacilities { get; set; }
    }   
}
