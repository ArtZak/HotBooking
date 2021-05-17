using HotBooking.Domain.Entities;
using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IRoomFacilitiesRepository
    {
        IQueryable<RoomFacility> GetAll();
        IQueryable<RoomFacilityModel> GetAllByCulture(CultureInfo culture);
        RoomFacility GetById(Guid id);
        RoomFacilityModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(RoomFacility entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(RoomFacility entity);
        Type GetEntityType();
    }
}
