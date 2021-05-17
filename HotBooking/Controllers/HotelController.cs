using HotBooking.Domain;
using HotBooking.Domain.Entities;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Controllers
{
    public class HotelController : Controller
    {
        private readonly DataManager dataManager;

        public HotelController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Hotel(Guid hotelId, DateTime arrival, DateTime departure, int roomsCount, int guests)
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            ViewBag.Culture = culture;

            var currHotel = dataManager.Hotels.GetById(hotelId);
            
            ViewBag.Arrival = arrival;
            ViewBag.Departure = departure;
            ViewBag.RoomsCount = roomsCount;
            ViewBag.Guests = guests;

            var rooms = new List<KeyValuePair<Room, int>>();

            foreach (var room in currHotel.Rooms)
            {
                var count = dataManager.BookedDates.GetAll().Count(d => d.RoomId == room.Id && (d.StartDate <= arrival && d.EndDate >= arrival || d.StartDate <= departure && d.EndDate >= departure));
                if (count < room.Count)
                {
                    rooms.Add(new KeyValuePair<Room, int>(room, room.Count - count));
                }
            }

            ViewBag.Rooms = rooms;

            return View(currHotel);
        }

        public IActionResult Reserve(int roomsCount, string roomId, DateTime arrival, DateTime departure, int guests)
        {
            ViewBag.Arrival = arrival;
            ViewBag.Departure = departure;
            ViewBag.Count = roomsCount;
            ViewBag.Guests = guests;
            ViewBag.RoomId = roomId;

            return View(new BookedDate() { StartDate = arrival, EndDate = departure, RoomId = Guid.Parse(roomId) });
        }

        public IActionResult CompleteBooking(BookedDate model, int roomsCount, int guests)
        {
            var currRoom = dataManager.Rooms.GetById(model.RoomId);
            if (!(currRoom.Count - dataManager.BookedDates.GetAll().Count(d => d.RoomId == model.RoomId && (d.StartDate <= model.StartDate && d.EndDate >= model.StartDate || d.StartDate <= model.EndDate && d.EndDate >= model.EndDate)) >= roomsCount) ||
                model.Email == null || model.UserName == null || model.Phone == null)
            {
                ViewBag.Count = roomsCount;
                ViewBag.Guests = guests;
                return RedirectToAction("Reserve", "Hotel", new { roomsCount = roomsCount, roomId = currRoom.Id, arrival = model.StartDate, departure = model.EndDate, guests = guests});
            }

            List<BookedDate> models = new List<BookedDate>();

            for (int i = 0; i < roomsCount; i++)
            {
                var newModel = new BookedDate()
                {
                    Email = model.Email,
                    EndDate = model.EndDate,
                    Phone = model.Phone,
                    RoomId = model.RoomId,
                    StartDate = model.StartDate,
                    UserName = model.UserName
                };
                models.Add(newModel);
            }

            dataManager.BookedDates.Save(models);

            return View();
        }
    }
}
