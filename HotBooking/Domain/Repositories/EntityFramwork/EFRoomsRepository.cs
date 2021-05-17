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

        public IQueryable<RoomModel> GetAllByCulture(CultureInfo culture)
        {
            if (culture.Name == "en-US")
            {
                return context.Rooms.Select(c =>
                        new RoomModel
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
                            RoomFacilities = c.RoomFacilities,
                            Count = c.Count,
                            Hotel = c.Hotel,
                            HotelId = c.HotelId
                        });
            }
            else
            {
                return context.Rooms.Select(c =>
                        new RoomModel
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
                            RoomFacilities = c.RoomFacilities,
                            Count = c.Count,
                            Hotel = c.Hotel
                        });
            }
        }

        public Room GetById(Guid id)
        {
            return context.Rooms.FirstOrDefault(x => x.Id == id);
        }

        public RoomModel GetByIdAndCulture(Guid id, CultureInfo culture)
        {
            var city = context.Rooms.FirstOrDefault(c => c.Id == id);
            if (city is null)
            {
                return null;
            }

            if (culture.Name == "en-US")
            {
                return new RoomModel
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
                    Count = city.Count,
                    Hotel = city.Hotel,
                    HotelId = city.HotelId,
                    PricePerNight = city.PricePerNight,
                    RoomFacilities = city.RoomFacilities,
                    RoomRoomFacilities = city.RoomRoomFacilities,
                    Visitors = city.Visitors
                };
            }
            else
            {
                return new RoomModel
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
                    Visitors = city.Visitors,
                    RoomRoomFacilities = city.RoomRoomFacilities,
                    RoomFacilities = city.RoomFacilities,
                    PricePerNight = city.PricePerNight,
                    HotelId = city.HotelId,
                    Hotel = city.Hotel,
                    Count = city.Count
                };
            }
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
            var list = new List<String>() { "Title", "Subtitle", "Text", "Price", "Visitors", "Count", "Title image path", "Hotel Id", "Date added" };
            return list;
        }

        public List<String> GetData(Room entity)
        {
            var list = new List<String>();

            list.Add(entity.TitleEn.ToString());
            list.Add(entity.SubtitleEn?.ToString());
            list.Add(entity.TextEn?.ToString());
            list.Add(entity.PricePerNight.ToString());
            list.Add(entity.Visitors.ToString());
            list.Add(entity.Count.ToString());
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
