using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpFit__main.Models
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int foodID { get; set; }

        [Required(ErrorMessage = "Type Required")]
        public int type { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string name { get; set; }
        [Required(ErrorMessage = "Calories Required")]
        public double? calories { get; set; }
        [Required(ErrorMessage = "Proteins Required")]
        public double? proteins { get; set; }
        [Required(ErrorMessage = "Fats Required")]
        public double? fats { get; set; }
        [Required(ErrorMessage = "Carbs Required")]
        public double? carbs { get; set; }
        [Required(ErrorMessage = "Fibers Required")]
        public double? fibers { get; set; }
        [Required(ErrorMessage = "Vitamin A Required")]
        public double? vitamin_A { get; set; }
        [Required(ErrorMessage = "Vitamin B Required")]
        public double? vitamin_B { get; set; }
        [Required(ErrorMessage = "Vitamin C Required")]
        public double? vitamin_C { get; set; }
        [Required(ErrorMessage = "Vitamin D Required")]
        public double? vitamin_D { get; set; }
        [Required(ErrorMessage = "Vitamin E Required")]
        public double? vitamin_E { get; set; }
    }
}