using Microsoft.EntityFrameworkCore;
using RorasCargoExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargoExercise.Entities
{
    public class RocketContext : DbContext
    {
        public RocketContext(DbContextOptions<RocketContext>options) : base(options)
        {

        }
        public DbSet<Rocket> Rockets { get; set; }
    }
}

    
