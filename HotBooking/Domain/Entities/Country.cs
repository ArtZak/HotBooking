using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Country : EntityBase
    {
        public bool IsFavorite { get; set; } = false;
        public virtual ICollection<City> Cities { get; set; }

        public CountryModel GetModel(CultureInfo culture)
        {
            if (culture.Name == "en-US")
            {
                return new CountryModel 
                { 
                    Cities = Cities,
                    DateAdded = DateAdded,
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
                return new CountryModel
                {
                    Cities = Cities,
                    DateAdded = DateAdded,
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
