using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InNutrition.Models
{
    public class ProgramHabits
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DietaryChoice { get; set; }
        public int Duration { get; set; }
    }
}
