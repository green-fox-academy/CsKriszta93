using FoxManager.Entities;
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

        public List<Models.Task> GetTaks()
        {
            return FoxContext.Tasks.ToList();
        }

        public void AddTask(string taskname)
        {
            FoxContext.Tasks.Add(new Models.Task { TaskName = taskname });
            FoxContext.SaveChanges();
        }
    }
}
