using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietplannerBlazor.Data
{
    public class FoodEntry
    {
        public FoodEntry(double quantity, Food food)
        {
            Quantity = quantity;
            Food = food;
        }

        public double Quantity { get; set; }
        public Food Food { get; set; }

        public double Calories => Food.Macros.Calories * (Quantity / 100);
    }
}
