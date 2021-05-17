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

        public IQueryable<HotelModel> GetAllByCulture(CultureInfo culture)
        {
            if (culture.Name == "en-US")
            {
                return context.Hotels.Select(c =>
                        new HotelModel
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
                            Adress = c.Adress,
                            City = c.City,
                            CityId = c.CityId,
                            DistanceToCenter = c.DistanceToCenter,
                            Food = c.Food,
                            HotelHotelFacilities = c.HotelHotelFacilities,
                            ReviewRating = c.ReviewRating,
                            Reviews = c.Reviews,
                            Rooms = c.Rooms,
                            Stars = c.Stars
                            
                        });
            }
            else
            {
                return context.Hotels.Select(c =>
                        new HotelModel
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
                            Adress = c.Adress,
                            City = c.City,
                            CityId = c.CityId,
                            DistanceToCenter = c.DistanceToCenter,
                            Food = c.Food,
                            HotelHotelFacilities = c.HotelHotelFacilities,
                            ReviewRating = c.ReviewRating,
                            Reviews = c.Reviews,
                            Rooms = c.Rooms,
                            Stars = c.Stars
                            
                        });
            }
        }

        public Hotel GetById(Guid id)
        {
            return context.Hotels.FirstOrDefault(x => x.Id == id);
        }

        public HotelModel GetByIdAndCulture(Guid id, CultureInfo culture)
        {
            var city = context.Hotels.FirstOrDefault(c => c.Id == id);
            if (city is null)
            {
                return null;
            }

            if (culture.Name == "en-US")
            {
                return new HotelModel
                {
                    Title = city.TitleEn,
                    Subtitle = city.SubtitleEn,
                    Text = city.TextEn,
                    DateAdded = city.DateAdded,
                    Id = city.Id,
                    IsFavorite = city.IsFavorite,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    TitleImagePath = city.TitleImagePath,
                    Adress = city.Adress,
                    City = city.City,
                    CityId = city.CityId,
                    DistanceToCenter = city.DistanceToCenter,
                    Food = city.Food,
                    HotelHotelFacilities = city.HotelHotelFacilities,
                    ReviewRating = city.ReviewRating,
                    Reviews = city.Reviews,
                    Rooms = city.Rooms,
                    Stars = city.Stars
                            
                };
            }
            else
            {
                return new HotelModel
                {
                    Title = city.TitleArm,
                    Subtitle = city.SubtitleArm,
                    Text = city.TextArm,
                    DateAdded = city.DateAdded,
                    Id = city.Id,
                    IsFavorite = city.IsFavorite,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    TitleImagePath = city.TitleImagePath,
                    Adress = city.Adress,
                    City = city.City,
                    CityId = city.CityId,
                    DistanceToCenter = city.DistanceToCenter,
                    Food = city.Food,
                    HotelHotelFacilities = city.HotelHotelFacilities,
                    ReviewRating = city.ReviewRating,
                    Reviews = city.Reviews,
                    Rooms = city.Rooms,
                    Stars = city.Stars
                };
            }
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

            list.Add(entity.TitleEn.ToString());
            list.Add(entity.SubtitleEn?.ToString());
            list.Add(entity.TextEn?.ToString());
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
