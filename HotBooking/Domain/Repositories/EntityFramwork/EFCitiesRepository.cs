using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using HotBooking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public IQueryable<CityModel> GetAllByCulture(CultureInfo culture)
        {
            if(culture.Name == "en-US")
            {
                return context.Cities.Select(c => 
                        new CityModel { Title = c.TitleEn, 
                        Subtitle = c.SubtitleEn, 
                        Text = c.TextEn,
                        Country = c.Country,
                        CountryId = c.CountryId,
                        DateAdded = c.DateAdded,
                        Hotels = c.Hotels,
                        Id = c.Id,
                        IsFavorite = c.IsFavorite,
                        MetaDescription = c.MetaDescription,
                        MetaKeywords = c.MetaKeywords,
                        MetaTitle = c.MetaTitle,
                        TitleImagePath = c.TitleImagePath});
            }
            else
            {
                return context.Cities.Select(c =>
                        new CityModel
                        {
                            Title = c.TitleArm,
                            Subtitle = c.SubtitleArm,
                            Text = c.TextArm,
                            Country = c.Country,
                            CountryId = c.CountryId,
                            DateAdded = c.DateAdded,
                            Hotels = c.Hotels,
                            Id = c.Id,
                            IsFavorite = c.IsFavorite,
                            MetaDescription = c.MetaDescription,
                            MetaKeywords = c.MetaKeywords,
                            MetaTitle = c.MetaTitle,
                            TitleImagePath = c.TitleImagePath
                        });
            }
        }

        public City GetById(Guid id)
        {
            return context.Cities.FirstOrDefault(x => x.Id == id);
        }

        public CityModel GetByIdAndCulture(Guid id, CultureInfo culture)
        {
            var city = context.Cities.FirstOrDefault(c => c.Id == id);
            if(city is null)
            {
                return null;
            }

            if(culture.Name == "en-US")
            {
                return new CityModel
                {
                    Id = city.Id,
                    Country = city.Country,
                    CountryId = city.CountryId,
                    DateAdded = city.DateAdded,
                    Hotels = city.Hotels,
                    IsFavorite = city.IsFavorite,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleEn,
                    Text = city.TextEn,
                    Title = city.TitleEn,
                    TitleImagePath = city.TitleImagePath
                };
            }
            else
            {
                return new CityModel
                {
                    Id = city.Id,
                    Country = city.Country,
                    CountryId = city.CountryId,
                    DateAdded = city.DateAdded,
                    Hotels = city.Hotels,
                    IsFavorite = city.IsFavorite,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleArm,
                    Text = city.TextArm,
                    Title = city.TitleArm,
                    TitleImagePath = city.TitleImagePath
                };
            }
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

            list.Add(entity.TitleEn.ToString());
            list.Add(entity.SubtitleEn?.ToString());
            list.Add(entity.TextEn?.ToString());
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
