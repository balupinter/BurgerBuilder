using System.ComponentModel.DataAnnotations;

namespace BurgerBuilderApp.Models
{
    public class Ingredient
    {
        // TODO-CORE-1: Property 'Name' must contain a non-null value. Consider adding the 'required' modifier or declaring the property as nullable.
        [Required]
        public string? Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}
