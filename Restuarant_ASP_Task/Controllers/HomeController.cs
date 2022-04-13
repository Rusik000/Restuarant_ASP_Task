using Microsoft.AspNetCore.Mvc;
using Restuarant_ASP_Task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restuarant_ASP_Task.Controllers
{
    public class HomeController : Controller
    {

        private IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }

        public IActionResult About()
        {
            var model = _repository.GetAll();
            return View(model);
        }

        public IActionResult Special_Dishes()
        {
            var model = _repository.GetAll();
            return View(model);

        }

        public IActionResult Menu()
        {
            var model = _repository.GetAll();
            return View(model);
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
