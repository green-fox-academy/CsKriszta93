using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Class
    {
        public long Id { get; set; }
        public string Task { get; set; }
        public int DueDate { get; set; }
        public int PriorityLevel { get; set; }
        public long StudentId { get; set; }
        public int TeamId { get; set; }
    }
}
