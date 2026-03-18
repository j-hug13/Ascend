using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend
{
    public class Workout
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        public int? Sets { get; set; }
        public int? Reps { get; set; }
        public double? Weight { get; set; }

        public double? Duration { get; set; }
        public double? Distance { get; set; }

        public Workout(string name)
        {
            Name = name;
        }
    }
}
