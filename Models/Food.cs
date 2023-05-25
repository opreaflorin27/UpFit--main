using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpFit__main.Models
{
    public class Food
    {
        [Key]
        public int foodID { get; set; }

        public int type { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string name { get; set; }

        public double? calories { get; set; }

        public double? proteins { get; set; }

        public double? fats { get; set; }

        public double? carbs { get; set; }

        public double? fibers { get; set; }

        public double? vitamin_A { get; set; }

        public double? vitamin_B { get; set; }

        public double? vitamin_C { get; set; }

        public double? vitamin_D { get; set; }

        public double? vitamin_E { get; set; }
    }
}