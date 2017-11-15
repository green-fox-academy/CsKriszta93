using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieTable.Repositories;
using CalorieTable.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalorieTable.Controllers
{
    public class HomeController : Controller
    {
        FoodRepository foodRepository;

        public HomeController(FoodRepository foodRepository)
        {
            this.foodRepository = foodRepository;
        }

        [HttpGet]
        [Route("/drax")]
        public IActionResult List()
        {
            return View(foodRepository.FoodList());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddFood(Food food)
        {
            foodRepository.AddFood(food);
            return RedirectToAction("List");
        }
    }
}
