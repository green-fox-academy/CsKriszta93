using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Repositories;
using TodoList.Models;

namespace TodoList.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return View(todoRepository.GetTasks());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(string title)
        {
            todoRepository.AddTask(title);
            return RedirectToAction("List");
        }

        [HttpGet]
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            todoRepository.RemoveTask(id);
            return RedirectToAction("todo");
        }
    }
}
