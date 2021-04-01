using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IInspirationItemsRepository InspirationItems { get; set; }
        public ICitiesRepository Cities { get; set; }
        public ICountriesRepository Countries { get; set; }
        public IHotelsRepository Hotels { get; set; }
        public IHotelFacilitiesRepository HotelFacilities { get; set; }
        public IReviewsRepository Reviews { get; set; }
        public IRoomsRepository Rooms { get; set; }
        public IRoomFacilitiesRepository RoomFacilities { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, 
                            IInspirationItemsRepository inspirationItemsRepository,
                            ICitiesRepository citiesRepository,
                            ICountriesRepository countriesRepository,
                            IHotelsRepository hotelsRepository,
                            IHotelFacilitiesRepository hotelFacilitiesRepository,
                            IReviewsRepository reviewsRepository,
                            IRoomsRepository roomsRepository,
                            IRoomFacilitiesRepository roomFacilitiesRepository)
        {
            TextFields = textFieldsRepository;
            InspirationItems = inspirationItemsRepository;
            Cities = citiesRepository;
            Countries = countriesRepository;
            Hotels = hotelsRepository;
            HotelFacilities = hotelFacilitiesRepository;
            Reviews = reviewsRepository;
            Rooms = roomsRepository;
            RoomFacilities = roomFacilitiesRepository;

        }
    }
}
