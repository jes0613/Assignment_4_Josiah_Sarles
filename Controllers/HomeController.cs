using Assignment_4_Josiah_Sarles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Josiah_Sarles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserRestaurants()
        {
            return View(TempStorage.Restaurants);
        }

        [HttpGet]
        public IActionResult RestaurantsForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RestaurantsForm(AddRestaurant appResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(appResponse);
                return View("Confirm", appResponse);
            }
            else
            {
                return View();
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
