using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietplannerBlazor.Data
{
    public class DietplanService
    {

        public Task<Dietplan> GetDietPlanAsync()
        {
            var dietplan = new Dietplan()
            {
                FoodEntries = new List<FoodEntry>()
                {
                    new FoodEntry(150, new Food("Thunfisch", new MacroNutrients(25, 0, 2))),
                    new FoodEntry(30, new Food("Gouda", new MacroNutrients(25, 0, 20))),
                    new FoodEntry(150, new Food("Nudeln", new MacroNutrients(13, 60, 4))),
                }
            };
            return Task.FromResult(dietplan);
        }


    }
}
