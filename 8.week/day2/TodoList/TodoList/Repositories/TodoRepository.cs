using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;
using TodoList.Models;

namespace TodoList.Repositories
{
    public class TodoRepository
    {
        TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public List<Todo> GetListOfTasks()
        {
            return todoContext.Todos.ToList();
        }

        public void AddTask(Todo todo)
        {
            todoContext.Todos.Add(todo);
            todoContext.SaveChanges();
        }
    }
}
