using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercise.Models;

namespace Exercise.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        static int counter = 0;
        // GET: /<controller>/

        [Route("greeting")]
        public IActionResult Greeting(string input)
        {
            var greeting = new Greeting();
            greeting.Id = ++counter;
            greeting.Content = $"Id: {greeting.Id} Hello {input}";
            return new JsonResult(greeting);
        }
    }
}
