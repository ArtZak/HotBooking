using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Room : EntityBase
    {
        [Required]
        public decimal PricePerNight { get; set; }
        [Required]
        public int Visitors { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public Guid HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<RoomFacility> RoomFacilities { get; set; }
        public virtual ICollection<RoomRoomFacility> RoomRoomFacilities { get; set; }

        public RoomModel GetModel(CultureInfo culture)
        {
            if(culture.Name == "en-US")
            {
                return new RoomModel
                {
                    DateAdded = DateAdded,
                    Id = Id,
                    MetaDescription = MetaDescription,
                    MetaKeywords = MetaKeywords,
                    MetaTitle = MetaTitle,
                    Subtitle = SubtitleEn,
                    Text = TextEn,
                    Title = TitleEn,
                    TitleImagePath = TitleImagePath,
                    Count = Count,
                    Hotel = Hotel,
                    HotelId = HotelId,
                    PricePerNight = PricePerNight,
                    RoomFacilities = RoomFacilities,
                    RoomRoomFacilities = RoomRoomFacilities,
                    Visitors = Visitors
                };
            }
            else
            {
                return new RoomModel
                {
                    DateAdded = DateAdded,
                    Id = Id,
                    MetaDescription = MetaDescription,
                    MetaKeywords = MetaKeywords,
                    MetaTitle = MetaTitle,
                    Subtitle = SubtitleArm,
                    Text = TextArm,
                    Title = TitleArm,
                    TitleImagePath = TitleImagePath,
                    Count = Count,
                    Hotel = Hotel,
                    HotelId = HotelId,
                    PricePerNight = PricePerNight,
                    RoomFacilities = RoomFacilities,
                    RoomRoomFacilities = RoomRoomFacilities,
                    Visitors = Visitors
                };
            }
        }
    }
}
