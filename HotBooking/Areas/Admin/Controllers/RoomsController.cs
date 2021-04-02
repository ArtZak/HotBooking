using HotBooking.Domain;
using HotBooking.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Room model, FormFile titleImageFile, string defaultImagePath)
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
                dataManager.Rooms.Save(model);
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
