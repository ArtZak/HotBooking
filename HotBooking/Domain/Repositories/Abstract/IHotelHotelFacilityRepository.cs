using HotBooking.Domain.Entities;
using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IHotelHotelFacilityRepository
    {
        IQueryable<HotelHotelFacility> GetAll();
        IQueryable<HotelHotelFacilityModel> GetAllByCulture(CultureInfo culture);
        HotelHotelFacility GetById(Guid hotelId, Guid facilityId);
        HotelHotelFacilityModel GetByIdAndCulture(Guid hotelId, Guid facilityId, CultureInfo culture);
        void Save(HotelHotelFacility entity);
        void Save(IEnumerable<HotelHotelFacility> entities);
        void Delete(Guid hotelId, Guid facilityId);
        void Delete(List<(Guid, Guid)> idPairs);
        List<String> GetDataNames();
        List<String> GetData(HotelHotelFacility entity);
        Type GetEntityType();
    }
}
