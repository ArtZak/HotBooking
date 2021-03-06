using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IReviewsRepository
    {
        IQueryable<Review> GetAll();
        Review GetById(Guid id);
        void Save(Review entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(Review entity);
        Type GetEntityType();
    }
}
