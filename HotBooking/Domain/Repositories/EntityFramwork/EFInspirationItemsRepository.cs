using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFInspirationItemsRepository : IInspirationItemsRepository
    {
        private readonly AppDbContext context;
        public EFInspirationItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<InspirationItem> GetAll()
        {
            return context.InspirationItems;
        }

        public InspirationItem GetById(Guid id)
        {
            return context.InspirationItems.FirstOrDefault(x => x.Id == id);
        }

        public void Save(InspirationItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.InspirationItems.Remove(new InspirationItem() { Id = id });
            context.SaveChanges();
        }

        public Type GetEntityType()
        {
            return typeof(InspirationItem);
        }
    }
}
