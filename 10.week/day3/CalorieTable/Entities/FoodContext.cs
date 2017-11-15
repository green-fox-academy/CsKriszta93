using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieTable.Entities
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext>options) : base(options)
        {

        }
    }
}
