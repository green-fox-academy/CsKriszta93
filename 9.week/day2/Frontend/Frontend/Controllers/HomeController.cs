using Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}" });
            }
        }

        [HttpGet]
        [Route("/appenda /{appendable}")]
        [Route("appenda")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable != null)
            {
                return Json(new { appended = $"{appendable}a" });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult Dountil(string what, [FromBody] int? number )
        {
            int result = 0;

            if (number == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else if (what == "sum")
            {              
                for (int i = 0; i < number; i++)
                {
                    result += i;
                }              
            }
            else if (what == "factor")
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
            }
            return Json(new { until = number, result = result });
        }

        [HttpPost]
        [Route("/arrays/{what}")]
        public IActionResult Arrays(string what, [FromBody] ArrayClass numbers)
        {
            int result = 0;

            if (numbers.array.Length == 0)
            {
                return Json(new { error = "Please provide an array" });
            }

            for (int i = 1; i < numbers.array.Length; i++)
            {
                if (what == "sum")
                {
                    result += numbers.array[i];
                }

                if (what == "multiply")
                {
                    result *= numbers.array[i];
                }

                if (what == "double")
                {
                    result = numbers.array[i * 2];
                }
            }

            return Json(new { result = result });
        }
    }
}
