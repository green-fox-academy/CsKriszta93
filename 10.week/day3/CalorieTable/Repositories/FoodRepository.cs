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

        public void AddFood(Food food)
        {
            foodContext.Foods.Add(food);
            foodContext.SaveChanges();
        }

        public Food GetId(long id)
        {
            return foodContext.Foods.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(long id)
        {
            foodContext.Foods.Remove(GetId(id));
            foodContext.SaveChanges();
        }

        public void ChangeAmount(Food food)
        {
            foodContext.Update(food);
            foodContext.SaveChanges();
        }

        public Food FindFood(long id)
        {
            return foodContext.Foods.FirstOrDefault();
        }
    }
}
