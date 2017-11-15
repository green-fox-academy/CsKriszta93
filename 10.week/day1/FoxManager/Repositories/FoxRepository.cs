using FoxManager.Entities;
using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class FoxRepository
    {
        FoxContext FoxContext;

        public FoxRepository(FoxContext foxContext)
        {
            FoxContext = foxContext;
        }

        public List<Models.Task> GetTasks()
        {
            return FoxContext.Tasks.ToList();
        }

        public void AddTask(string taskname)
        {
            FoxContext.Tasks.Add(new Models.Task { TaskName = taskname });
            FoxContext.SaveChanges();
        }

        public bool CheckStudentExists(string name)
        {
            var checkstudent = FoxContext.Students.FirstOrDefault(student => student.Name.Equals(name));
            return checkstudent != null ? false : true;
        }

        public Student StudentInfo(string name)
        {
            var selectedstudent = (from student in FoxContext.Students
                                   where student.Name == name
                                   select student).FirstOrDefault();
            return selectedstudent;
        }

        public List<Models.Task> GetStudentTasks(string name)
        {
            return FoxContext.Tasks.Where(y => y.Student.Name.Equals(name)).ToList();
        }
    }
}
