using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IHotelsRepository 
    {
        IQueryable<Hotel> GetAll();
        Hotel GetById(Guid id);
        void Save(Hotel entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
