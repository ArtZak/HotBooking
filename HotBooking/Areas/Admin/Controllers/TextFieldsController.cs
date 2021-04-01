using Microsoft.AspNetCore.Mvc;
using HotBooking.Domain;
using HotBooking.Domain.Entities;
using HotBooking.Service;

namespace HotBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;
        public TextFieldsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TextFields.Save(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
