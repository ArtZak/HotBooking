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
    public class CountriesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public CountriesController(DataManager dataManager, IWebHostEnvironment environment)
        {
            this.dataManager = dataManager;
            hostEnvironment = environment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Country() : dataManager.Countries.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Country model, IFormFile titleImageFile, string defaultImagePath)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = "images/countries/" + titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, model.TitleImagePath), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                else
                {
                    model.TitleImagePath = defaultImagePath;
                }
                dataManager.Countries.Save(model);
                return RedirectToAction("Read", "Home");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Countries.Delete(id);
            return RedirectToAction("Read", "Home");
        }
    }
}
