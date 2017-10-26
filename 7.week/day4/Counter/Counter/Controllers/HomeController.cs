using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    public class HomeController : Controller
    {
        CounterClass counter;

        public HomeController(CounterClass counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        { 
            return View(counter);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Counter()
        {
            counter.IncreaseCounter();
            return RedirectToAction("Index"); ;
        }
    }
}
