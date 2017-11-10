using System;
using System.Collections.Generic;
using System.IO;
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

        public List<Todo> GetTasks()
        {
            return todoContext.Todos.ToList();
        }

        public List<Todo> TasksTodo()
        {
            var tasks = from todo in todoContext.Todos
                        where !todo.IsDone
                        select todo;
            return tasks.ToList();
        }

        public void AddTask(string title)
        {
            todoContext.Todos.Add(new Todo { Title = title });
            todoContext.SaveChanges();
        }

        public void RemoveTask(int id)
        {
            var remove = (from todo in todoContext.Todos
                            where todo.Id == id
                            select todo).FirstOrDefault();

            todoContext.Todos.Remove(remove);
            todoContext.SaveChanges();
        }
    }
}
