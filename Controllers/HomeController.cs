using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kursovaya.Models;

namespace Kursovaya.Controllers
{
    public class HomeController : Controller
    {
        private BrandContext BDB;
        public HomeController(BrandContext context)
        {
            BDB = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LabView()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<IActionResult> Create(BikeBrandsDB Brand)
        {
            BDB.Brands.Add(Brand);
            await BDB.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
