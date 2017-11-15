using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Repositories;

namespace FoxManager.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        FoxRepository FoxRepository;

        public HomeController(FoxRepository foxRepository)
        {
            FoxRepository = foxRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
