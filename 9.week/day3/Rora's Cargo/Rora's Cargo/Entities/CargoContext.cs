using Microsoft.EntityFrameworkCore;
using RorasCargo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargo.Entities
{
    public class CargoContext : DbContext
    {
        public CargoContext(DbContextOptions<CargoContext>options) : base(options)
        {

        }

        public DbSet<Cargo> Cargos { get; set; }
    }
}
