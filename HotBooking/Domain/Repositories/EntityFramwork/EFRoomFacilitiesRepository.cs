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

        public IQueryable<RoomFacilityModel> GetAllByCulture(CultureInfo culture)
        {
            if (culture.Name == "en-US")
            {
                return context.RoomFacilities.Select(c =>
                        new RoomFacilityModel
                        {
                            Title = c.TitleEn,
                            Subtitle = c.SubtitleEn,
                            Text = c.TextEn,
                            DateAdded = c.DateAdded,
                            Id = c.Id,
                            MetaDescription = c.MetaDescription,
                            MetaKeywords = c.MetaKeywords,
                            MetaTitle = c.MetaTitle,
                            TitleImagePath = c.TitleImagePath,
                            RoomRoomFacilities = c.RoomRoomFacilities,
                            Rooms = c.Rooms
                        });
            }
            else
            {
                return context.RoomFacilities.Select(c =>
                        new RoomFacilityModel
                        {
                            Title = c.TitleArm,
                            Subtitle = c.SubtitleArm,
                            Text = c.TextArm,
                            DateAdded = c.DateAdded,
                            Id = c.Id,
                            MetaDescription = c.MetaDescription,
                            MetaKeywords = c.MetaKeywords,
                            MetaTitle = c.MetaTitle,
                            TitleImagePath = c.TitleImagePath,
                            Rooms = c.Rooms,
                            RoomRoomFacilities = c.RoomRoomFacilities
                        });
            }
        }

        public RoomFacility GetById(Guid id)
        {
            return context.RoomFacilities.FirstOrDefault(x => x.Id == id);
        }

        public RoomFacilityModel GetByIdAndCulture(Guid id, CultureInfo culture)
        {
            var city = context.RoomFacilities.FirstOrDefault(c => c.Id == id);
            if (city is null)
            {
                return null;
            }

            if (culture.Name == "en-US")
            {
                return new RoomFacilityModel
                {
                    Id = city.Id,
                    DateAdded = city.DateAdded,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleEn,
                    Text = city.TextEn,
                    Title = city.TitleEn,
                    TitleImagePath = city.TitleImagePath,
                    RoomRoomFacilities = city.RoomRoomFacilities,
                    Rooms = city.Rooms
                };
            }
            else
            {
                return new RoomFacilityModel
                {
                    Id = city.Id,
                    DateAdded = city.DateAdded,
                    MetaDescription = city.MetaDescription,
                    MetaKeywords = city.MetaKeywords,
                    MetaTitle = city.MetaTitle,
                    Subtitle = city.SubtitleArm,
                    Text = city.TextArm,
                    Title = city.TitleArm,
                    TitleImagePath = city.TitleImagePath,
                    Rooms = city.Rooms,
                    RoomRoomFacilities = city.RoomRoomFacilities
                };
            }
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

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Title", "Subtitle", "Text", "Title image path", "Date added" };
            return list;
        }

        public List<String> GetData(RoomFacility entity)
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
            return typeof(RoomFacility);
        }
    }
}
