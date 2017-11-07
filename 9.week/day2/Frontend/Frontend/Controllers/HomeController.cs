using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult JsonResult(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { recieved = input, result = input * 2 });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        [Route("")]
        public IActionResult Greeting(string name, string title)
        {
            if (name == null || title == null)
            {
                return Json(new { error_message = "Please, provide a name" });
            }

            return Json(new { welcome_message = "Oh hi there {0}, my dear {1}", name, title });
        }
    }
}
