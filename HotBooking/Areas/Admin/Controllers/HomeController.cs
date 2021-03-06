using HotBooking.Domain;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HotBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Read()
        {
            return View(dataManager);
        }

        [HttpPost]
        public IActionResult Read(string table)
        {
            ViewBag.SelectedTable = table;
            return View(dataManager);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(string table)
        {
            ViewBag.SelectedTable = table;
            return View(dataManager);
        }
    }
}
