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

        public IActionResult Country(Guid countryId)
        {
            var country = dataManager.Countries.GetById(countryId);
            return View(country);
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
