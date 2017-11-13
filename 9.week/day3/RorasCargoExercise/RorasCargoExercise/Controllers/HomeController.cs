using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RorasCargoExercise.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RorasCargoExercise.Controllers
{
    [Route("rocket")]
    public class HomeController : Controller
    {
        RocketRepository RocketRepository;

        
        public HomeController(RocketRepository rocketRepository)
        {
            RocketRepository = rocketRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            return View(RocketRepository.GetRockets());
        }

        [HttpGet]
        [Route("load")]
        public IActionResult Load()
        {
            return View();
        }

        [HttpPost]
        [Route("load")]
        public IActionResult LoadShip(int caliber)
        {
            RocketRepository.AddRocket(caliber);
            return RedirectToAction("List");
        }
    }
}
