using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UpFit__main.Models
{
    public class FoodType
    {
        [Key]
        public int TypeID { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
    }
}