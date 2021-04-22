using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietplannerBlazor.Data
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Food> Food { get; set; }

        public FoodDbContext(DbContextOptions<FoodDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(GetFoods());
            modelBuilder.Entity<Food>().Property(f => f.Id).ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        }

        private List<Food> GetFoods()
        {
            return new List<Food>
            {
                new Food("Thunfisch", new MacroNutrients(25, 0, 2)),
                new Food("Gouda", new MacroNutrients(25, 0, 20)),
                new Food("Nudeln", new MacroNutrients(13, 60, 4)),
                new Food("Ketchup", new MacroNutrients(0.1, 2.4, 0)),
                new Food("Spargel", new MacroNutrients(2.2, 3.9, 0.1))
            };
        }
    }
}
