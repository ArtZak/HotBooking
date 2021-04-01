using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFReviewsRepository : IReviewsRepository
    {
        private readonly AppDbContext context;
        public EFReviewsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Review> GetAll()
        {
            return context.Reviews;
        }

        public Review GetById(Guid id)
        {
            return context.Reviews.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Review entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Reviews.Remove(new Review() { Id = id });
            context.SaveChanges();
        }

        public Type GetEntityType()
        {
            return typeof(Review);
        }
    }
}
