using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class City : EntityBase
    {
        public bool IsFavorite { get; set; } = false;

        [Required]
        public Guid CountryId { get; set; }      
        public virtual Country Country { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }

        public CityModel GetModel(CultureInfo culture)
        {
            if(culture.Name == "en-US")
            {
                return new CityModel
                {
                    Country = Country,
                    CountryId = CountryId,
                    DateAdded = DateAdded,
                    Hotels = Hotels,
                    Id = Id,
                    IsFavorite = IsFavorite,
                    MetaDescription = MetaDescription,
                    MetaKeywords = MetaKeywords,
                    MetaTitle = MetaTitle,
                    Subtitle = SubtitleEn,
                    Text = TextEn,
                    Title = TitleEn,
                    TitleImagePath = TitleImagePath
                };
            }
            else
            {
                return new CityModel
                {
                    Country = Country,
                    CountryId = CountryId,
                    DateAdded = DateAdded,
                    Hotels = Hotels,
                    Id = Id,
                    IsFavorite = IsFavorite,
                    MetaDescription = MetaDescription,
                    MetaKeywords = MetaKeywords,
                    MetaTitle = MetaTitle,
                    Subtitle = SubtitleArm,
                    Text = TextArm,
                    Title = TitleArm,
                    TitleImagePath = TitleImagePath
                };
            }
        }
    }
}
