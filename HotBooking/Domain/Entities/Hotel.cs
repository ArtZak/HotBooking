using HotBooking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class Hotel : EntityBase
    {
        [Display(Name = "Stars")]
        public byte Stars { get; set; }

        [Display(Name = "Distance to center")]
        public double DistanceToCenter { get; set; }

        [Display(Name = "Food")]
        public string Food { get; set; }

        [Display(Name = "Review rating")]
        public double ReviewRating { get; set; }
        
        [Display(Name = "Adress")]
        public string Adress { get; set; }

        [Display(Name = "Is Favorite")]
        public bool IsFavorite { get; set; } = false;

        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<HotelHotelFacility> HotelHotelFacilities { get; set; }

        [Required]
        public Guid CityId { get; set; }
        public virtual City City { get; set; }

        public HotelModel GetModel(CultureInfo culture)
        {
            if(culture.Name == "en-US")
            {
                return new HotelModel
                {
                    Adress = Adress,
                    City = City,
                    CityId = CityId,
                    DateAdded = DateAdded,
                    DistanceToCenter = DistanceToCenter,
                    Food = Food,
                    HotelHotelFacilities = HotelHotelFacilities,
                    Id = Id,
                    IsFavorite = IsFavorite,
                    MetaDescription = MetaDescription,
                    MetaKeywords = MetaKeywords,
                    MetaTitle = MetaTitle,
                    ReviewRating = ReviewRating,
                    Reviews = Reviews,
                    Rooms = Rooms,
                    Stars = Stars,
                    Subtitle = SubtitleEn,
                    Text = TextEn,
                    Title = TitleEn,
                    TitleImagePath = TitleImagePath
                };
            }
            else
            {
                return new HotelModel
                {
                    Adress = Adress,
                    City = City,
                    CityId = CityId,
                    DateAdded = DateAdded,
                    DistanceToCenter = DistanceToCenter,
                    Food = Food,
                    HotelHotelFacilities = HotelHotelFacilities,
                    Id = Id,
                    IsFavorite = IsFavorite,
                    MetaDescription = MetaDescription,
                    MetaKeywords = MetaKeywords,
                    MetaTitle = MetaTitle,
                    ReviewRating = ReviewRating,
                    Reviews = Reviews,
                    Rooms = Rooms,
                    Stars = Stars,
                    Subtitle = SubtitleArm,
                    Text = TextArm,
                    Title = TitleArm,
                    TitleImagePath = TitleImagePath
                };
            }
        }
    }
}
