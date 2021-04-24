using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IBookedDatesRepository
    {
        IQueryable<BookedDate> GetAll();
        BookedDate GetById(Guid id);
        void Save(BookedDate entity);
        void Save(IEnumerable<BookedDate> entities);
        void Delete(Guid id);
    }
}
