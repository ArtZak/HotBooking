using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFRoomsRepository : IRoomsRepository
    {
        private readonly AppDbContext context;
        public EFRoomsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Room> GetAll()
        {
            return context.Rooms;
        }

        public Room GetById(Guid id)
        {
            return context.Rooms.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Room entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Rooms.Remove(new Room() { Id = id });
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Title", "Subtitle", "Text", "Title image path", "Hotel Id", "Date added" };
            return list;
        }

        public List<String> GetData(Room entity)
        {
            var list = new List<String>();

            list.Add(entity.Title.ToString());
            list.Add(entity.Subtitle.ToString());
            list.Add(entity.Text.ToString());
            list.Add(entity.TitleImagePath?.ToString());
            list.Add(entity.HotelId.ToString());
            list.Add(entity.DateAdded.ToString());

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(Room);
        }
    }
}
