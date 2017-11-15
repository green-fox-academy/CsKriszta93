using CalorieTable.Entities;
using CalorieTable.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieTable.Repositories
{
    public class FoodRepository
    {
        FoodContext foodContext;

        public FoodRepository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }

        public DbSet<Food> Foods { get; set; }
    }
}
