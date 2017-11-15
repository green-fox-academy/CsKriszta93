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

        public List<Food> FoodList()
        {
            return foodContext.Foods.ToList();
        }

        public void AddFood(string name)
        {
            foodContext.Foods.Add(new Food { Name = name });
            foodContext.SaveChanges();
        }

        public Food GetId(long id)
        {
            return foodContext.Foods.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(long id)
        {
            var
        }
    }
}
