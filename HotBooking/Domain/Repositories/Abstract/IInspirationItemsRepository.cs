using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IInspirationItemsRepository
    {
        IQueryable<InspirationItem> GetAll();
        InspirationItem GetById(Guid id);
        void Save(InspirationItem entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
