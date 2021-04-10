using HotBooking.Domain;
using HotBooking.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager);
        }


        [HttpPost]
        public IActionResult Search(string destination,
                                    DateTime arrival,
                                    DateTime departure,
                                    int adults,
                                    int children,
                                    int rooms)
        {
            var countries = dataManager.Countries.GetAll();
            IQueryable<City> cities;
            List<Hotel> hotels = new List<Hotel>();

            IQueryable<Country> selectedCountry = from t in countries where t.Title.ToLower() == destination.ToLower() select t;
            if (selectedCountry.GetEnumerator().MoveNext() == true)
            {
                var _cities = selectedCountry.FirstOrDefault().Cities;
                foreach (var city in _cities)
                {
                    hotels.AddRange(city.Hotels);
                }
                ViewBag.DestinationName = hotels[0]?.City.Country.Title;
            }
            else
            {
                cities = dataManager.Cities.GetAll();
                var selectedCity = from t in cities where t.Title.ToLower() == destination.ToLower() select t;

                if (selectedCity.GetEnumerator().MoveNext() == false)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    var city = selectedCity.FirstOrDefault();
                    hotels = city.Hotels?.ToList();
                    ViewBag.DestinationName = hotels[0]?.City.Title;
                }
            }

            if(hotels == null)
            {
                return RedirectToAction("Index");
            }
            
            return View(hotels);
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}
