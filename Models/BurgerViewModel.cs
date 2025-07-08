using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BurgerBuilderApp.Models
{
    public class BurgerViewModel
    {
        // TODO-CORE-1: Property 'SelectedIngredients' must contain a non-null value. Consider adding the 'required' modifier or declaring the property as nullable.
        [Required]
        public List<Ingredient> SelectedIngredients { get; set; } = new List<Ingredient>();
        public decimal TotalCost { get; set; }
    }
}
