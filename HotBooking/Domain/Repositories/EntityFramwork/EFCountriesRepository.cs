using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFCountriesRepository : ICountriesRepository
    {
        private readonly AppDbContext context;
        public EFCountriesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Country> GetAll()
        {
            return context.Countries;
        }

        public Country GetById(Guid id)
        {
            return context.Countries.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Country entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Countries.Remove(new Country() { Id = id });
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Title", "Subtitle", "Text", "Is Favorite", "Title image path", "Date added"};            
            return list;
        }

        public List<String> GetData(Country entity)
        {
            var list = new List<String>();

            list.Add(entity.Title.ToString());
            list.Add(entity.Subtitle.ToString());
            list.Add(entity.Text.ToString());
            list.Add(entity.IsFavorite.ToString());                                 
            list.Add(entity.TitleImagePath?.ToString());
            list.Add(entity.DateAdded.ToString());

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(Country);
        }
    }
}
