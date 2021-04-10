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
    public class HotelsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public HotelsController(DataManager manager, IWebHostEnvironment environment)
        {
            dataManager = manager;
            hostEnvironment = environment;
        }

        public IActionResult Edit(Guid id)
        {   
            ViewBag.Facilities = dataManager.HotelFacilities.GetAll().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Title, Selected = dataManager.HotelHotelFacilities.GetById(id, r.Id) != null}).ToList();
            var entity = id == default ? new Hotel() : dataManager.Hotels.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Hotel model, IFormFile titleImageFile, string defaultImagePath, List<String> facilities)
        {
            if (ModelState.IsValid)
            {
                if(titleImageFile != null)
                {
                    model.TitleImagePath = "images/hotels/" + titleImageFile.FileName;

                    using(var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, model.TitleImagePath), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                else
                {
                    model.TitleImagePath = defaultImagePath;
                }
                dataManager.Hotels.Save(model);

                var hotelFacilities = dataManager.HotelHotelFacilities.GetAll().Where(r => r.HotelId == model.Id);
                List<(Guid, Guid)> deletable = new List<(Guid, Guid)>();
                foreach (var item in hotelFacilities)
                {
                    bool flag = false;
                    foreach (var item2 in facilities)
                    {
                        if (item.HotelFacilityId == Guid.Parse(item2))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        deletable.Add((model.Id, item.HotelFacilityId));
                    }
                }
                dataManager.HotelHotelFacilities.Delete(deletable);

                List<HotelHotelFacility> hotelHotelFacilities = new List<HotelHotelFacility>();
                foreach (var item in facilities)
                {
                    var facilityId = Guid.Parse(item);
                    hotelHotelFacilities.Add(new HotelHotelFacility { HotelId = model.Id, HotelFacilityId = facilityId });
                    
                }

                dataManager.HotelHotelFacilities.Save(hotelHotelFacilities);

                return RedirectToAction("Read", "Home");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Hotels.Delete(id);
            return RedirectToAction("Read", "Home");
        }
    }
}
