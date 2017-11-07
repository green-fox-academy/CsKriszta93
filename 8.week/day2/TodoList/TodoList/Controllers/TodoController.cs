using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Repositories;
using TodoList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoList.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("")]
        [Route("/list")]
        public IActionResult List()
        {
            return View(todoRepository.GetListOfTasks());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Todo todo)
        {
            todoRepository.AddTask(todo);
            return RedirectToAction ("List");
        }
    }
}
