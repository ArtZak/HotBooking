using HotBooking.Domain;
using HotBooking.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly DataManager dataManager;

        public ReviewController(DataManager data)
        {
            dataManager = data;
        }

        [HttpGet]
        public IActionResult Index(Guid currHotel)
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            ViewBag.Culture = culture;

            var currentUser = dataManager.UserManager.GetUserAsync(User).Result;
            ViewBag.User = currentUser;
            ViewBag.Hotel = dataManager.Hotels.GetById(currHotel);

            return View();
        }

        public IActionResult SendReview(Review model)
        {
            dataManager.Reviews.Save(model);
            var hotel = dataManager.Hotels.GetById(model.HotelId);
            hotel.ReviewRating = hotel.Reviews.Sum(h => h.Rating) / (double)hotel.Reviews.Count;
            dataManager.Hotels.Save(hotel);

            return View();
        }
    }
}
