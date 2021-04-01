using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFRoomFacilitiesRepository : IRoomFacilitiesRepository
    {
        private readonly AppDbContext context;
        public EFRoomFacilitiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<RoomFacility> GetAll()
        {
            return context.RoomFacilities;
        }

        public RoomFacility GetById(Guid id)
        {
            return context.RoomFacilities.FirstOrDefault(x => x.Id == id);
        }

        public void Save(RoomFacility entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.RoomFacilities.Remove(new RoomFacility() { Id = id });
            context.SaveChanges();
        }

        public Type GetEntityType()
        {
            return typeof(RoomFacility);
        }
    }
}
