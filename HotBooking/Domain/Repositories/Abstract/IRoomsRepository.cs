using HotBooking.Domain.Entities;
using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IRoomsRepository
    {
        IQueryable<Room> GetAll();
        IQueryable<RoomModel> GetAllByCulture(CultureInfo culture);
        Room GetById(Guid id);
        RoomModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(Room entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(Room entity);
        Type GetEntityType();
    }
}
