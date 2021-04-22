using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietplannerBlazor.Data
{
    public class Food
    {

        public Food() : this("", new MacroNutrients(0, 5, 0), new MicroNutrients()) { }
        public Food(string name, MacroNutrients macros, MicroNutrients micros)
        {
            Id = id;
            Name = name;
            Macros = macros;
            Micros = micros;
        }

        public Food(string name, MacroNutrients macros) : this(name, macros, new MicroNutrients()) { }

        public int Id { get; set; }

        public string Name { get; set; }

        public MacroNutrients Macros { get; set; }

        public MicroNutrients Micros { get; set; }

    }
}
