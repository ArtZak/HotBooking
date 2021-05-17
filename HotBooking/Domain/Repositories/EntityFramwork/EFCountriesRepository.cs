using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using HotBooking.Models;
using System.Globalization;

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

        public IQueryable<CountryModel> GetAllByCulture(CultureInfo culture)
        {
            if (culture.Name == "en-US")
            {
                return context.Countries.Select(c =>
                        new CountryModel
                        {
                            Title = c.TitleEn,
                            Subtitle = c.SubtitleEn,
                            Text = c.TextEn,
                            DateAdded = c.DateAdded,
                            Id = c.Id,
                            IsFavorite = c.IsFavorite,
                            MetaDescription = c.MetaDescription,
                            MetaKeywords = c.MetaKeywords,
                            MetaTitle = c.MetaTitle,
                            TitleImagePath = c.TitleImagePath,
                            Cities = c.Cities
                        });
            }
            else
            {
                return context.Countries.Select(c =>
                        new CountryModel
                        {
                            Title = c.TitleArm,
                            Subtitle = c.SubtitleArm,
                            Text = c.TextArm,
                            DateAdded = c.DateAdded,
                            Id = c.Id,
                            IsFavorite = c.IsFavorite,
                            MetaDescription = c.MetaDescription,
                            MetaKeywords = c.MetaKeywords,
                            MetaTitle = c.MetaTitle,
                            TitleImagePath = c.TitleImagePath,
                            Cities = c.Cities
                        });
            }
        }

        public Country GetById(Guid id)
        {
            return context.Countries.FirstOrDefault(x => x.Id == id);
        }

        public CountryModel GetByIdAndCulture(Guid id, CultureInfo culture)
        {
            var city = context.Countries.FirstOrDefault(c => c.Id == id);
            if (city is null)
            {
                return null;
            }

            if (culture.Name == "en-US")
            {
                return new CountryModel
                {
                    Id = city.Id,
                    DateAdded = city.DateAdded,
                    IsFavorite = city.IsFavorite,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleEn,
                    Text = city.TextEn,
                    Title = city.TitleEn,
                    TitleImagePath = city.TitleImagePath,
                    Cities = city.Cities
                };
            }
            else
            {
                return new CountryModel
                {
                    Id = city.Id,
                    DateAdded = city.DateAdded,
                    IsFavorite = city.IsFavorite,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleArm,
                    Text = city.TextArm,
                    Title = city.TitleArm,
                    TitleImagePath = city.TitleImagePath,
                    Cities = city.Cities
                };
            }
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

            list.Add(entity.TitleEn.ToString());
            list.Add(entity.SubtitleEn.ToString());
            list.Add(entity.TextEn.ToString());
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
