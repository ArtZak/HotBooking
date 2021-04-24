using HotBooking.Domain;
using HotBooking.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Controllers
{
    public class SearchController : Controller
    {
        private readonly DataManager dataManager;

        public SearchController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        [HttpPost]
        public IActionResult Search(string destination,
                                    DateTime arrival,
                                    DateTime departure,
                                    int adults,
                                    int children,
                                    int rooms = 1)
        {
            var guests = adults + children;

            var countries = dataManager.Countries.GetAll();
            IQueryable<City> cities;
            List<KeyValuePair<Hotel, bool>> hotels = new List<KeyValuePair<Hotel, bool>>();

            IQueryable<Country> selectedCountry = from t in countries where t.Title.ToLower() == destination.ToLower() select t;
            if (selectedCountry.GetEnumerator().MoveNext() == true)
            {
                var _cities = selectedCountry.FirstOrDefault().Cities;
                foreach (var city in _cities)
                {
                    foreach(var hotel in city.Hotels)
                    {
                        var maxGuestsCount = 0;
                        var maxRoomsCount = 0;
                        foreach (var room in hotel.Rooms.OrderByDescending(x => x.Visitors))
                        {
                            var reservedCount = dataManager.BookedDates.GetAll().Count(d => d.RoomId == room.Id && (d.StartDate <= arrival && d.EndDate >= arrival || d.StartDate <= departure && d.EndDate >= departure));
                            if (room.Count > reservedCount)
                            {
                                maxGuestsCount += room.Visitors * (room.Count - reservedCount);
                                maxRoomsCount += room.Count - reservedCount; 
                                if(maxRoomsCount >= rooms)
                                {
                                    break;
                                }                                    
                            }                           
                        }
                        if (maxRoomsCount >= rooms && maxGuestsCount >= guests)
                        {
                            hotels.Add(new KeyValuePair<Hotel, bool>(hotel, true));
                        }
                    }
                }
                ViewBag.DestinationName = hotels[0].Key.City.Country.Title;
            }
            else
            {
                cities = dataManager.Cities.GetAll();
                var selectedCity = from t in cities where t.Title.ToLower() == destination.ToLower() select t;

                if (selectedCity.GetEnumerator().MoveNext() == false)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    var city = selectedCity.FirstOrDefault();
                    foreach (var hotel in city.Hotels)
                    {
                        var maxGuestsCount = 0;
                        var maxRoomsCount = 0;
                        foreach (var room in hotel.Rooms.OrderByDescending(x => x.Visitors))
                        {
                            var reservedCount = dataManager.BookedDates.GetAll().Count(d => d.RoomId == room.Id && (d.StartDate <= arrival && d.EndDate >= arrival || d.StartDate <= departure && d.EndDate >= departure));
                            if (room.Count > reservedCount)
                            {
                                maxGuestsCount += room.Visitors * (room.Count - reservedCount);
                                maxRoomsCount += room.Count - reservedCount;
                                if (maxRoomsCount >= rooms)
                                {
                                    break;
                                }
                            }
                        }
                        if (maxRoomsCount >= rooms && maxGuestsCount >= guests)
                        {
                            hotels.Add(new KeyValuePair<Hotel, bool>(hotel, true));
                        }
                    }
                    ViewBag.DestinationName = hotels[0].Key.City.Title;
                }
            }

            if (hotels == null)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Facilities = dataManager.HotelFacilities.GetAll();
            ViewBag.RoomFacilities = dataManager.RoomFacilities.GetAll();
            ViewBag.Arrival = arrival;
            ViewBag.Departure = departure;
            ViewBag.Guests = guests;
            ViewBag.Rooms = rooms;

            return View(hotels);
        }

        public IActionResult Filter(List<Guid> hotelsId, 
                                    List<int> budget, 
                                    List<byte> stars, 
                                    List<double> distance, 
                                    List<Guid> hotelFacilities, 
                                    List<Guid> roomFacilities,
                                    string destination)
        {
            ViewBag.Facilities = dataManager.HotelFacilities.GetAll();
            ViewBag.RoomFacilities = dataManager.RoomFacilities.GetAll();
            ViewBag.DestinationName = destination;

            var hotels = new List<KeyValuePair<Hotel, bool>>();

            foreach (var id in hotelsId)
            {
                bool isStar = false;
                bool isDistance = false;
                bool isHotelFacility = false;
                bool isRoomFacility = false;
                bool isBudget = false;

                int[] prices = new int[] { 0, 31400, 62800, 94300, 125000, int.MaxValue };
                var hotel = dataManager.Hotels.GetById(id);

                //Checking hotels with specified count of stars.
                if (stars == null || stars.Count == 0 || stars.Contains(hotel.Stars))
                {
                    isStar = true;
                }

                //Checking hotels with specified distance from centre.
                if(distance == null || distance.Count == 0 || distance.Any(x => x >= hotel.DistanceToCenter))
                {
                    isDistance = true;
                }

                //Checking hotels with specified facilities
                if(hotelFacilities == null || hotelFacilities.Count == 0)
                {
                    isHotelFacility = true;
                }
                else
                {
                    var flag = true;
                    foreach (var item in hotelFacilities)
                    {
                        if (!hotel.HotelHotelFacilities.Any(f => f.HotelFacilityId == item))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        isHotelFacility = true;
                    }
                }
                
                //Checking hotels with specified room facilities
                if(roomFacilities == null || roomFacilities.Count == 0)
                {
                    isRoomFacility = true;
                }               
                else
                {                   
                    foreach(var room in hotel.Rooms)
                    {
                        var flag = true;

                        foreach (var item in roomFacilities)
                        {
                            if (!room.RoomRoomFacilities.Any(rf => rf.RoomFacilityId == item))
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            isRoomFacility = true;
                            break;
                        }
                    }
                   
                }

                //Checking hotels with specified room facilities
                if (budget == null || budget.Count == 0)
                {
                    isBudget = true;
                }
                else
                {
                    foreach (var room in hotel.Rooms)
                    {
                        var flag = false;

                        foreach(var price in budget)
                        {
                            var index = Array.IndexOf(prices, price);

                            if (room.PricePerNight >= prices[index - 1] && room.PricePerNight <= prices[index])
                            {
                                isBudget = true;
                                flag = true;
                                break;
                            } 
                        }

                        if (flag)
                        {
                            break;
                        }
                    }
                }

                if (isStar && isDistance && isHotelFacility && isRoomFacility && isBudget)
                {
                    hotels.Add(new KeyValuePair<Hotel, bool>(hotel, true));
                }
                else
                {
                    hotels.Add(new KeyValuePair<Hotel, bool>(hotel, false));
                }
            }

            return View("Search", hotels);
        }
    }
}
