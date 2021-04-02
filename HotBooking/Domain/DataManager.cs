using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void GetSelectedTable(PropertyInfo table, out dynamic selectedTable)
        {
            if (table.PropertyType == typeof(ICitiesRepository))
            {
                selectedTable = (ICitiesRepository)table.GetValue(this);
                return;
            }
            else if (table.PropertyType == typeof(ICountriesRepository))
            {
                selectedTable = (ICountriesRepository)table.GetValue(this);
                return;
            }
            else if (table.PropertyType == typeof(IHotelFacilitiesRepository))
            {
                selectedTable = (IHotelFacilitiesRepository)table.GetValue(this);
                return;
            }
            else if (table.PropertyType == typeof(IHotelsRepository))
            {
                selectedTable = (IHotelsRepository)table.GetValue(this);
                return;
            }
            else if (table.PropertyType == typeof(IInspirationItemsRepository))
            {
                selectedTable = (IInspirationItemsRepository)table.GetValue(this);
                return;
            }
            else if (table.PropertyType == typeof(IReviewsRepository))
            {
                selectedTable = (IReviewsRepository)table.GetValue(this);
                return;
            }
            else if (table.PropertyType == typeof(IRoomFacilitiesRepository))
            {
                selectedTable = (IRoomFacilitiesRepository)table.GetValue(this);
                return;
            }
            else if (table.PropertyType == typeof(IRoomsRepository))
            {
                selectedTable = (IRoomsRepository)table.GetValue(this);
                return;
            }
            selectedTable = (ICountriesRepository)table.GetValue(this);
        }
    }
}
