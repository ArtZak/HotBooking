using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IRoomsRepository
    {
        IQueryable<Room> GetAll();
        Room GetById(Guid id);
        void Save(Room entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
