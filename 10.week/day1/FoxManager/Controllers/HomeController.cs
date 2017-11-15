using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Repositories;
using FoxManager.Models;
using FoxManager.Services;

namespace FoxManager.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        FoxService FoxService;

        public HomeController(FoxService foxService)
        {
            FoxService = foxService;
        }

        [HttpPost]
        public IActionResult LoginHandler(Student studentFromForm)
        {
            if (FoxService.AuthenticateStudent(studentFromForm.Name))
            {
                return LocalRedirect("/student/" + studentFromForm.Name);
            }

            return LocalRedirect("/");
        }

        [HttpGet]
        [Route("/student/{studentName}")]
        public IActionResult Profile(string studentName)
        {
            var selectedStudent = FoxService.GetStudentInfo(studentName);
            var projects = FoxService.GetTasks(studentName);
            return View(selectedStudent);
        }
    }
}
