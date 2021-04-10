using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Country : EntityBase
    {
        public bool IsFavorite { get; set; } = false;
        public virtual ICollection<City> Cities { get; set; }
    }
}
