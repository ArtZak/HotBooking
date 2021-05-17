using HotBooking.Domain.Entities;
using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IHotelFacilitiesRepository
    {
        IQueryable<HotelFacility> GetAll();
        IQueryable<HotelFacilityModel> GetAllByCulture(CultureInfo culture);
        HotelFacility GetById(Guid id);
        HotelFacilityModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(HotelFacility entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(HotelFacility entity);
        Type GetEntityType();
    }
}
