using Microsoft.EntityFrameworkCore;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext>options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
