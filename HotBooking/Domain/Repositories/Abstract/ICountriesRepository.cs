using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface ICountriesRepository
    {
        IQueryable<Country> GetAll();
        Country GetById(Guid id);
        void Save(Country entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
