using HotBooking.Domain;
using HotBooking.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public RoomsController(DataManager manager, IWebHostEnvironment environment)
        {
            dataManager = manager;
            hostEnvironment = environment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Room() : dataManager.Rooms.GetById(id);
            ViewBag.Facilities = dataManager.RoomFacilities.GetAll().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Title, Selected = dataManager.RoomRoomFacilities.GetById(id, r.Id) != null }).ToList();
            ViewBag.Hotels = dataManager.Hotels.GetAll().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Title, Selected = entity.HotelId == r.Id }).ToList();
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Room model, IFormFile titleImageFile, string defaultImagePath, List<String> facilities, String hotel)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = "images/rooms/" + titleImageFile.FileName;

                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, model.TitleImagePath), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                else
                {
                    model.TitleImagePath = defaultImagePath;
                }
                model.HotelId = Guid.Parse(hotel);
                dataManager.Rooms.Save(model);

                var roomFacilities = dataManager.RoomRoomFacilities.GetAll().Where(r => r.RoomId == model.Id);
                List<(Guid, Guid)> deletable = new List<(Guid, Guid)>();
                foreach (var item in roomFacilities)
                {
                    bool flag = false;
                    foreach (var item2 in facilities)
                    {
                        if (item.RoomFacilityId == Guid.Parse(item2))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        deletable.Add((model.Id, item.RoomFacilityId));
                    }
                }
                dataManager.RoomRoomFacilities.Delete(deletable);

                List<RoomRoomFacility> roomRoomFacilities = new List<RoomRoomFacility>();
                foreach (var item in facilities)
                {
                    var facilityId = Guid.Parse(item);
                    roomRoomFacilities.Add(new RoomRoomFacility { RoomId = model.Id, RoomFacilityId = facilityId });

                }

                dataManager.RoomRoomFacilities.Save(roomRoomFacilities);

                return RedirectToAction("Read", "Home");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Rooms.Delete(id);
            return RedirectToAction("Read", "Home");
        }
    }
}
