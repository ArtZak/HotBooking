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
    public class EFHotelFacilitiesRepository : IHotelFacilitiesRepository
    {
        private readonly AppDbContext context;
        public EFHotelFacilitiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<HotelFacility> GetAll()
        {
            return context.HotelFacilities;
        }

        public IQueryable<HotelFacilityModel> GetAllByCulture(CultureInfo culture)
        {
            if (culture.Name == "en-US")
            {
                return context.HotelFacilities.Select(c =>
                        new HotelFacilityModel
                        {
                            Title = c.TitleEn,
                            Subtitle = c.SubtitleEn,
                            Text = c.TextEn,
                            DateAdded = c.DateAdded,
                            Hotels = c.Hotels,
                            Id = c.Id,
                            MetaDescription = c.MetaDescription,
                            MetaKeywords = c.MetaKeywords,
                            MetaTitle = c.MetaTitle,
                            TitleImagePath = c.TitleImagePath,
                            HotelHotelFacilities = c.HotelHotelFacilities
                        });
            }
            else
            {
                return context.HotelFacilities.Select(c =>
                        new HotelFacilityModel
                        {
                            Title = c.TitleArm,
                            Subtitle = c.SubtitleArm,
                            Text = c.TextArm,
                            DateAdded = c.DateAdded,
                            Hotels = c.Hotels,
                            Id = c.Id,
                            MetaDescription = c.MetaDescription,
                            MetaKeywords = c.MetaKeywords,
                            MetaTitle = c.MetaTitle,
                            TitleImagePath = c.TitleImagePath,
                            HotelHotelFacilities = c.HotelHotelFacilities
                        });
            }
        }

        public HotelFacility GetById(Guid id)
        {
            return context.HotelFacilities.FirstOrDefault(x => x.Id == id);
        }

        public HotelFacilityModel GetByIdAndCulture(Guid id, CultureInfo culture)
        {
            var city = context.HotelFacilities.FirstOrDefault(c => c.Id == id);
            if (city is null)
            {
                return null;
            }

            if (culture.Name == "en-US")
            {
                return new HotelFacilityModel
                {
                    Id = city.Id,
                    DateAdded = city.DateAdded,
                    Hotels = city.Hotels,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleEn,
                    Text = city.TextEn,
                    Title = city.TitleEn,
                    TitleImagePath = city.TitleImagePath,
                    HotelHotelFacilities = city.HotelHotelFacilities
                };
            }
            else
            {
                return new HotelFacilityModel
                {
                    Id = city.Id,
                    DateAdded = city.DateAdded,
                    Hotels = city.Hotels,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleArm,
                    Text = city.TextArm,
                    Title = city.TitleArm,
                    TitleImagePath = city.TitleImagePath,
                    HotelHotelFacilities = city.HotelHotelFacilities
                };
            }
        }

        public void Save(HotelFacility entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.HotelFacilities.Remove(new HotelFacility() { Id = id });
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Title", "Subtitle", "Text", "Title image path", "Date added" };
            return list;
        }

        public List<String> GetData(HotelFacility entity)
        {
            var list = new List<String>();

            list.Add(entity.TitleEn.ToString());
            list.Add(entity.SubtitleEn?.ToString());
            list.Add(entity.TextEn?.ToString());
            list.Add(entity.TitleImagePath?.ToString());
            list.Add(entity.DateAdded.ToString());

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(HotelFacility);
        }
    }
}
