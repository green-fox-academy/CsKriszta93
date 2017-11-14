using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnProject.Models
{
    public class Song
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Date { get; set; }
        public string Genre { get; set; }
    }
}
