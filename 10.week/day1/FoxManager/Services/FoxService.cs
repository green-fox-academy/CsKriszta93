using FoxManager.Models;
using FoxManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Services
{
    public class FoxService
    {
        FoxRepository FoxRepository;

        public FoxService(FoxRepository foxRepository)
        {
            FoxRepository = foxRepository;
        }

        public bool AuthenticateStudent(string name)
        {
            return FoxRepository.CheckStudentExists(name);
        }

        public Student GetStudentInfo(string name)
        {
            return FoxRepository.StudentInfo(name);
        }

        public List<Models.Task> GetTasks(string taskName)
        {
            return FoxRepository.GetTasks(taskName);
        }
    }
}
