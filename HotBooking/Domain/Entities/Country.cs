using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Country : EntityBase
    {
        public List<City> Cities { get; set; }
        public bool IsFavorite { get; set; } = false;
    }
}
