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
        public int FoodID { get; set; }

        public int FoodTypeID { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }


    }
}