using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OwnProject.Repositories;

namespace OwnProject.Controllers
{
    public class HomeController : Controller
    {
        SongRepository SongRepository;

        public HomeController(SongRepository songRepository)
        {
            SongRepository = songRepository;
        }

        [Route("/songs")]
        public IActionResult Songs()
        {
            return View(SongRepository.GetSongs());
        }
    }
}
