using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IRepositoryBase<T> where T: EntityBase
    {
        IQueryable<T> GetAll();
        T GetById(Guid id);
        void Save(T entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
