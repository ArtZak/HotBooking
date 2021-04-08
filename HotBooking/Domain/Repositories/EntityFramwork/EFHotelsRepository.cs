using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFHotelsRepository : IHotelsRepository
    {
        private readonly AppDbContext context;
        public EFHotelsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Hotel> GetAll()
        {
            return context.Hotels;
        }

        public Hotel GetById(Guid id)
        {
            return context.Hotels.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Hotel entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Hotels.Remove(new Hotel() { Id = id });
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Title", "Subtitle", "Text", "Is Favorite", "Food", "Title image path", "Date added", "City Id" };
            return list;
        }

        public List<String> GetData(Hotel entity)
        {
            var list = new List<String>();

            list.Add(entity.Title.ToString());
            list.Add(entity.Subtitle?.ToString());
            list.Add(entity.Text?.ToString());
            list.Add(entity.IsFavorite.ToString());
            list.Add(entity.Food?.ToString());
            list.Add(entity.TitleImagePath?.ToString());
            list.Add(entity.DateAdded.ToString());
            list.Add(entity.CityId.ToString());

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(Hotel);
        }
    }
}
