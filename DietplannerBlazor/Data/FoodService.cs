using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietplannerBlazor.Data
{
    public class FoodService
    {
        private FoodDbContext dbContext;

        public FoodService(FoodDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Food>> GetFoodsAsync()
        {
            return await dbContext.Food.ToListAsync();
        }

        public async Task<Food> AddFoodAsync(Food food)
        {
            try
            {
                dbContext.Food.Add(food);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return food;
        }

        public async Task<Food> UpdateFoodAsync(Food food)
        {
            try
            {
                var foodExists = dbContext.Food.FirstOrDefault(f => f.Name == food.Name);
                if (foodExists != null)
                {
                    dbContext.Update(food);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return food;
        }

        public async Task DeleteFoodAsync(Food food)
        {
            try
            {
                dbContext.Food.Remove(food);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}

