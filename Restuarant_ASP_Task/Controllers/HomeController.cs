using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restuarant_ASP_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Special_Dishes()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Reservation()
        {
            return View();
        }

    }
}
