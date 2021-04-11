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
    public class CitiesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public CitiesController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        
        // GET: CitiesController/Edit/5
        public IActionResult Edit(Guid id)
        {          
            var entity = id == default ? new City() : dataManager.Cities.GetById(id);
            ViewBag.Countries = dataManager.Countries.GetAll().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Title, Selected = entity.CountryId == r.Id}).ToList();
            return View(entity);
        }

        // POST: CitiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(City model, IFormFile titleImageFile, string defaultImagePath, string country)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = "images/favoriteCities/" + titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, model.TitleImagePath), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                else
                {
                    model.TitleImagePath = defaultImagePath;
                }

                model.CountryId = Guid.Parse(country);

                dataManager.Cities.Save(model);
                return RedirectToAction("Read", "Home");
            }
            return View(model);
        }


        // POST: CitiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id)
        {
            dataManager.Cities.Delete(id);
            return RedirectToAction("Read", "Home");
        }
    }
}
