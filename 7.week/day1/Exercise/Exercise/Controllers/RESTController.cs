using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercise.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercise.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/
        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greeting greeting = new Greeting();
            return new JsonResult(greeting);
        }
    }
}
