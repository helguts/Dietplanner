using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietplannerBlazor.Data
{
    public class MacroNutrients
    {
        private const double KCAL_PROTEIN_G = 4.1;
        private const double KCAL_CARBS_G = 4.1;
        private const double KCAL_FATS_G = 9.3;

        public MacroNutrients(double proteins, double carbs, double fats)
        {
            Proteins = proteins;
            Carbs = carbs;
            Fats = fats;
        }

        public double Proteins { get; set; }

        public double Carbs { get; set; }

        public double Fats { get; set; }

        public double Calories { get => (Proteins * KCAL_PROTEIN_G) + (Carbs * KCAL_CARBS_G) + (Fats * KCAL_FATS_G); }
    }
}
