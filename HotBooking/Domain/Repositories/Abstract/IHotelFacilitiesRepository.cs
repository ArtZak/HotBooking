using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IHotelFacilitiesRepository
    {
        IQueryable<HotelFacility> GetAll();
        HotelFacility GetById(Guid id);
        void Save(HotelFacility entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
