using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface ICitiesRepository
    {
        IQueryable<City> GetAll();
        City GetById(Guid id);
        void Save(City entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
