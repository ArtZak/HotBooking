using HotBooking.Domain.Entities;
using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface ICountriesRepository
    {
        IQueryable<Country> GetAll();
        IQueryable<CountryModel> GetAllByCulture(CultureInfo culture);
        Country GetById(Guid id);
        CountryModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(Country entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(Country entity);
        Type GetEntityType();
    }
}
