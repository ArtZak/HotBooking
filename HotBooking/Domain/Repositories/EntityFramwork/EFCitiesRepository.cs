using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFCitiesRepository : ICitiesRepository
    {
        private readonly AppDbContext context;
        public EFCitiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<City> GetAll()
        {
            return context.Cities;
        }

        public City GetById(Guid id)
        {
            return context.Cities.FirstOrDefault(x => x.Id == id);
        }

        public void Save(City entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Cities.Remove(new City() { Id = id });
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Title", "Subtitle", "Text", "Is Favorite", "Title image path", "Date added", "Country Id" };
            return list;
        }

        public List<String> GetData(City entity)
        {
            var list = new List<String>();

            list.Add(entity.Title.ToString());
            list.Add(entity.Subtitle?.ToString());
            list.Add(entity.Text?.ToString());
            list.Add(entity.IsFavorite.ToString());
            list.Add(entity.TitleImagePath?.ToString());
            list.Add(entity.DateAdded.ToString());
            list.Add(entity.CountryId.ToString());

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(City);
        }
    }
}
