using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;

namespace Reddit.Controllers
{
    public class HomeController : Controller
    {
        PostRepository postRepository;

        public HomeController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View(postRepository.GetPosts());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddPost(string content)
        {
            postRepository.AddPost(content);
            return RedirectToAction("Index");
        }
    }
}
