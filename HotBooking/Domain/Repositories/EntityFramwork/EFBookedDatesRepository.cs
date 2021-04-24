using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFBookedDatesRepository : IBookedDatesRepository
    {
        private readonly AppDbContext context;
        public EFBookedDatesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<BookedDate> GetAll()
        {
            return context.BookedDates;
        }

        public BookedDate GetById(Guid id)
        {
            return context.BookedDates.FirstOrDefault(x => x.Id == id);
        }

        public void Save(BookedDate entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Save(IEnumerable<BookedDate> entities)
        {
            foreach (var entity in entities)
            {
                if (entity.Id == default)
                    context.Entry(entity).State = EntityState.Added;
                else
                    context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.BookedDates.Remove(new BookedDate() { Id = id });
            context.SaveChanges();
        }

    }
}
