using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class HotelFacilityModel : BaseModel
    {
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<HotelHotelFacility> HotelHotelFacilities { get; set; }
    }
}
