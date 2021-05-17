using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class HotelFacility : EntityBase
    {
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<HotelHotelFacility> HotelHotelFacilities { get; set; }

        public HotelFacilityModel GetModel(CultureInfo culture)
        {
            if(culture.Name == "en-US")
            {
                return new HotelFacilityModel
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
                    HotelHotelFacilities = HotelHotelFacilities,
                    Hotels = Hotels
                };
            }
            else
            {
                return new HotelFacilityModel
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
                    Hotels = Hotels,
                    HotelHotelFacilities = HotelHotelFacilities
                };
            }
        }
    }   
}
