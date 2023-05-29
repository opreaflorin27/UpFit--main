using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpFit__main.Models
{
    public class Meal
    {
        [Key]
        public int mealID { get; set; }

        [Required]
        public int mealTypeFK { get; set;}

        [Required]
        public int userFK { get; set;}

        [Required]
        public int foodFK { get; set; }

        [Required]
        public int quantity { get; set;}

        [Required]
        public DateTime date { get; set; }
    }
}