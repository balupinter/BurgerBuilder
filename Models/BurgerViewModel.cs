using System.Collections.Generic;

namespace BurgerBuilderApp.Models
{
    public class BurgerViewModel
    {
        // TODO-CORE-1: Property 'SelectedIngredients' must contain a non-null value. Consider adding the 'required' modifier or declaring the property as nullable.
        public List<Ingredient> SelectedIngredients { get; set; }
        public decimal TotalCost { get; set; }
    }
}
