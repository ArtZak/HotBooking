using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Models
{
    public class CountryModel : BaseModel
    {
        public bool IsFavorite { get; set; } = false;
        public virtual ICollection<City> Cities { get; set; }
    }
}
