using HotBooking.Domain.Entities;
using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IHotelsRepository 
    {
        IQueryable<Hotel> GetAll();
        IQueryable<HotelModel> GetAllByCulture(CultureInfo culture);
        Hotel GetById(Guid id);
        HotelModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(Hotel entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(Hotel entity);
        Type GetEntityType();
    }
}
