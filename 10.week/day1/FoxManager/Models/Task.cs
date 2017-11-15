using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public string PriorityLevel{ get; set; }
        public int StudentId { get; set; }
        public int TeamId { get; set; }
        public Student Student { get; set; }
    }
}
