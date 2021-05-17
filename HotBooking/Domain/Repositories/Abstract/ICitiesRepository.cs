using HotBooking.Domain.Entities;
using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface ICitiesRepository
    {
        IQueryable<City> GetAll();
        IQueryable<CityModel> GetAllByCulture(CultureInfo culture);
        City GetById(Guid id);
        CityModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(City entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(City entity);
        Type GetEntityType();
    }
}
