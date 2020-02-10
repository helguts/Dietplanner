using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietplannerBlazor.Data
{
    public class Food
    {

        public Food(string name, MacroNutrients macros, MicroNutrients micros) : this(name, macros)
        {
            Micros = micros;
        }

        public Food(string name, MacroNutrients macros)
        {
            Name = name;
            Macros = macros;
        }

        public string Name { get; set; }

        public MacroNutrients Macros { get; set; }

        public MicroNutrients Micros { get; set; }

    }
}
