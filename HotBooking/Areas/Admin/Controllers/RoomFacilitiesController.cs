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
    public class RoomFacilitiesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public RoomFacilitiesController(DataManager manager, IWebHostEnvironment environment)
        {
            dataManager = manager;
            hostEnvironment = environment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new RoomFacility() : dataManager.RoomFacilities.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(RoomFacility model, IFormFile titleImageFile, string defaultImagePath)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = "images/roomFacilities/" + titleImageFile.FileName;

                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, model.TitleImagePath), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                else
                {
                    model.TitleImagePath = defaultImagePath;
                }
                dataManager.RoomFacilities.Save(model);
                return RedirectToAction("Read", "Home");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.RoomFacilities.Delete(id);
            return RedirectToAction("Read", "Home");
        }
    }
}
