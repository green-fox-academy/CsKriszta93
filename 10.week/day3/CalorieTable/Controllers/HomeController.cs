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
        public IEnumerable<Food> List()
        {
            return foodRepository.FoodList();
        }

        [HttpPost]
        [Route("/add")]
        public IActionResult AddFood([FromQuery] Food food)
        {
            if (food.Name == null)
            {
                return BadRequest();
            }
            else
            {
                foodRepository.AddFood(food);
                return Ok(food);
            }           
        }

        [HttpGet]
        [Route("/drax/{id}")]
        public IActionResult FindFoodById(long id)
        {
            var food = foodRepository.FindFood(id);
            if (food == null)
            {
                return NotFound();
            }
            return new ObjectResult(food);
        }

        [HttpGet]
        [Route("/api")]
        public IActionResult GetFirstFood()
        {
            return Json(new { name = foodRepository.FindFood().Name.ToString(), amount = foodRepository.FindFood().Amount.ToString(), calorie = foodRepository.FindFood().Calorie.ToString() });
        }
    }
}
