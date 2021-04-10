using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class HotelHotelFacility
    {
        public Guid HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public Guid HotelFacilityId { get; set; }
        public virtual HotelFacility HotelFacility { get; set; }
    }
}
