using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IHotelHotelFacilityRepository
    {
        IQueryable<HotelHotelFacility> GetAll();
        HotelHotelFacility GetById(Guid hotelId, Guid facilityId);
        void Save(HotelHotelFacility entity);
        void Save(IEnumerable<HotelHotelFacility> entities);
        void Delete(Guid hotelId, Guid facilityId);
        void Delete(List<(Guid, Guid)> idPairs);
        List<String> GetDataNames();
        List<String> GetData(HotelHotelFacility entity);
        Type GetEntityType();
    }
}
